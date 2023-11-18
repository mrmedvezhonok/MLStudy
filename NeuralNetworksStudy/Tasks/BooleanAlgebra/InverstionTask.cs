using NeuralNetworksStudy.Entities;

namespace NeuralNetworksStudy.Tasks.BooleanAlgebra {
	public class InverstionTask : AbstractTask {

		public override void Run() {
			var b = 1f;
			var testDataSets = new List<int>() { 0, 1 };
			var weight = -1f;
			var dendrits = new Dendrit[1] { new Dendrit() { Weight = weight } };

			var neuron = new Neuron() {
				Dendrits = dendrits,
				Offset = b
			};

			testDataSets.ForEach(dataSet => {
				var dendrit = dendrits.First();
				dendrit.Input = dataSet;

				var result = neuron.Calc();
				Console.WriteLine($"{dendrit.Input}-({dendrit.Weight})->[∑ b={neuron.Offset}]->{result}");
			});
		}
	}
}
