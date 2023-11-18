using NeuralNetworksStudy.Tasks;
using NeuralNetworksStudy.Tasks.BooleanAlgebra;

Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.WriteLine("Hey 👋");

var tasks = new List<AbstractTask>() {
	new InverstionTask(),
	new AndTask(),
	new OrTask(),
	new XorTask(),
};

tasks.Last().Run();