using NeuralNetworksStudy.Entities;

namespace NeuralNetworksStudy.Tasks.BooleanAlgebra {
	public class OrTask : AbstractTask {

		public override void Run() {
			var b = 0f;
			var testDataSets = new List<int[]>() {
				new int[] { 0, 0 },
				new int[] { 0, 1 },
				new int[] { 1, 0 },
				new int[] { 1, 1 }
			};
			var dendrits = new Dendrit[2] {
				new Dendrit() { Weight = 1f },
				new Dendrit() { Weight = 1f }
			};

			var neuron = new Neuron() {
				Dendrits = dendrits,
				Offset = b
			};

			testDataSets.ForEach(dataSet => {
				Console.WriteLine("\n______________________________________________________________________");
				Console.WriteLine("Test");
				Console.WriteLine("______________________________________________________________________");
				for (int i = 0; i < dendrits.Length; i++) {
					var dendrit = dendrits[i];
					dendrit.Input = dataSet[i];
				}

				var result = neuron.Calc();

				for (int i = 0; i < dendrits.Length; i++) {
					var dendrit = dendrits[i];
					Console.WriteLine($"{dendrit.Input}-({dendrit.Weight})--->");
				}
				Console.WriteLine($"[∑ b={neuron.Offset}]->{result}");
			});
			Console.WriteLine("\n______________________________________________________________________");
		}
	}
}
