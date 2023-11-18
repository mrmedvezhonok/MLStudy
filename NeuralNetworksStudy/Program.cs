using NeuralNetworksStudy.Tasks;
using NeuralNetworksStudy.Tasks.BooleanAlgebra;

Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.WriteLine("Hey 👋");

var tasks = new List<AbstractTask>() {
	new InverstionTask(),
	new AndTask(),
	new OrTask(),
};

tasks.Last().Run();