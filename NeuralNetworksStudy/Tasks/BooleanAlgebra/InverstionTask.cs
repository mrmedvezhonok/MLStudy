using NeuralNetworksStudy.Entities;

namespace NeuralNetworksStudy.Tasks.BooleanAlgebra
{
    public class InverstionTask : AbstractTask
    {

        public override void Run()
        {
            var b = 1f;
            var inputs = new float[2] { 0, 1 };
            var weight = -1f;
            var dendrits = new Dendrit[1] { new Dendrit(inputs[0], weight) };

            var neuron = new Neuron()
            {
                Dendrits = dendrits,
                Offset = b
            };

            var result0 = neuron.Calc();

            dendrits.First().Input = inputs[1];

            var result1 = neuron.Calc();

            Console.WriteLine($"{inputs[0]}-({weight})->[∑ b={b}]->{result0}");
            Console.WriteLine($"{inputs[1]}-({weight})->[∑ b={b}]->{result1}");
        }
    }
}
