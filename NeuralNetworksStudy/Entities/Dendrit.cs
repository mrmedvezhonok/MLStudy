namespace NeuralNetworksStudy.Entities {
	public class Dendrit {
		public float Input { get; set; }
		public float Weight { get; set; }

		public Dendrit(float input, float weight) {
			Input = input;
			Weight = weight;
		}
	}
}
