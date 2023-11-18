using NeuralNetworksStudy.Entities;

namespace NeuralNetworksStudy.Tasks.BooleanAlgebra {
	public class XorTask : AbstractTask {

		public override void Run() {
			var dataSets = new List<float[]>() {
				new float[] { 0, 0 },
				new float[] { 0, 1 },
				new float[] { 1, 0 },
				new float[] { 1, 1 },
			};

			Console.WriteLine("_______________");
			Console.WriteLine("|X1 | X2 | XOR|");
			Console.WriteLine("_______________");
			dataSets.ForEach(dataSet => {
				var result = CalcNetwork(dataSet);
				Console.WriteLine($"| {dataSet[0]} |  {dataSet[1]} |  {result} |");
			});
			Console.WriteLine("_______________");
		}

		private float CalcNetwork(float[] inputs) {
			var n1 = new Neuron() { Dendrits = new[] { new Dendrit() {Input = inputs[0], Weight = 1f }, new Dendrit() { Input = inputs[1], Weight = 1f } }, Offset = 0f };

			var n2 = new Neuron() { Dendrits = new[] { new Dendrit() { Input = inputs[0], Weight = 0.6f }, new Dendrit() { Input = inputs[1], Weight = 0.6f } }, Offset = -1f };

			var firstResult = n1.Calc();
			var secondResult = n2.Calc();

			var n3 = new Neuron() { Dendrits = new[] { new Dendrit() { Input = firstResult - secondResult, Weight = 1f } } };

			return n3.Calc();
		}
	}
}
