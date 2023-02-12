using Microsoft.Extensions.DependencyInjection;
using Study7.Domain;
using Study7.Servises;

IServiceCollection services = new ServiceCollection()
    .AddScoped<ICounter, RandomCounter>();
using ServiceProvider serviceProvider = services.BuildServiceProvider();
PrintCounters();
PrintCounters();
void PrintCounters()
{
    using (IServiceScope scope = serviceProvider.CreateScope())
    {
        var counter1 = scope.ServiceProvider.GetService<ICounter>();
        var counter2 = scope.ServiceProvider.GetService<ICounter>();
        Console.WriteLine($"Counter1:{counter1.Value}; Counter2:{counter2.Value}");
    }
}