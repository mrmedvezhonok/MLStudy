// See https://aka.ms/new-console-template for more information
using NeuralNetworksStudy.Entities;
using NeuralNetworksStudy.Tasks;

Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.WriteLine("Hey 👋");

AbstractTask task = new BooleanAlgebraInversionTask();
task.Run();