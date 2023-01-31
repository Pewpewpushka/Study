using _2.study_DI.Domain;
using _2.study_DI.Servises.CalculateServises;
using _2.study_DI.Servises.LogServises;
using Microsoft.Extensions.DependencyInjection;

// создание сервисной колекции(ioc контейнер)
IServiceCollection services = new ServiceCollection();
// добавляем сервис ILogService 
services = new ServiceCollection().AddTransient<ILogServise, GreenLogServise>();
// получам провайдер сервисов
 var serviseProvider = services.BuildServiceProvider();
// получаем сервис 
ILogServise logServise= serviseProvider.GetService<ILogServise>();
// используем полученный logServise
logServise.Write("hi-my dog");
services = new ServiceCollection().AddTransient<ICalculate, DeleteLogServisecs>();
ICalculate calculate = serviseProvider.GetService<ICalculate>();
calculate.Run(13, 7);
