
using Microsoft.Extensions.DependencyInjection;
using study3;
using study3.Domain;
using study3.Servises;

IServiceCollection services = new ServiceCollection().AddTransient<ILogServise, SimpleServise>().AddTransient<Loger>();

using ServiceProvider serviceProvider = services.BuildServiceProvider();
// получаем объект Logger
Loger logger = serviceProvider.GetService<Loger>();
logger.Log("Hello METANIT.COM");
