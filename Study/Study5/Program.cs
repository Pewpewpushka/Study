using Microsoft.Extensions.DependencyInjection;
using Study5.Domain;
using Study5.Servises;

IServiceCollection services = new ServiceCollection().AddSingleton<ICounter, RandomCounter>();
ServiceProvider serviceProvider = services.BuildServiceProvider();
PrintCounters();
PrintCounters();
void PrintCounters()
{
    ICounter counter1 = serviceProvider.GetService<ICounter>();
    ICounter counter2 = serviceProvider.GetService<ICounter>();
    Console.WriteLine($"Counter1: {counter1.Value}; Counter2: {counter2.Value}");
}