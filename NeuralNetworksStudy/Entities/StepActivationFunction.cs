namespace NeuralNetworksStudy.Entities {
	public class StepActivationFunction : AbstractActivationFunction {

		public override float Activate(float z) {
			return z > 0 ? 1 : 0;
		}
	}
}
