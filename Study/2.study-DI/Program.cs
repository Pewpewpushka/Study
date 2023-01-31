using _2.study_DI;
using _2.study_DI.Domain;
using _2.study_DI.Servises.CalculateServises;
using _2.study_DI.Servises.LogServises;
using Microsoft.Extensions.DependencyInjection;

// создание сервисной колекции(ioc контейнер)
IServiceCollection services = new ServiceCollection();
// добавляем сервис ILogService 
services.AddTransient<ILogServise, GreenLogServise>();
services.AddTransient<ICalculate, DeleteLogServisecs>();
// получам провайдер сервисов
 var serviseProvider = services.BuildServiceProvider();
// получаем сервис 
ILogServise logServise= serviseProvider.GetService<ILogServise>();
ICalculate calculate = serviseProvider.GetService<ICalculate>();
// используем полученный logServise
logServise.Write("hi-my dog");
calculate.Run(14, 5);
Loger loger = new Loger(logServise);
loger.Log("stady is coll? when are not stupid");

