using NeuralNetworksStudy.Exceptions;

namespace NeuralNetworksStudy.Entities {
	public class Neuron {
		public IEnumerable<Dendrit> Dendrits { get; set; } = null!;
		public float Offset { get; set; } = 0;
		private readonly AbstractActivationFunction _activationFunction;

		public Neuron(AbstractActivationFunction activationFunction = null) {
			_activationFunction = activationFunction ?? new StepActivationFunction();
		}

		private float Sum() {
			if (Dendrits is null || !Dendrits.Any() || Dendrits.Any(d => !d.Input.HasValue || !d.Weight.HasValue)) throw new NeuronIsInvalidException("Dendrits was not defined.");

			var result = 0f;
			foreach (var dendrit in Dendrits) {
				result += dendrit.Input!.Value * dendrit.Weight!.Value;
			}
			result += Offset;
			return result;
		}

		public float Calc() {
			var z = Sum();
			var result = _activationFunction.Activate(z);
			return result;
		}
	}
}
