# Study
1. создаем итерфейс сервиса.создаем контракт(метод без реализации)
2. создаем сервис. реализуем о  интерфейса 
3. работа с DI
3.1. устанавливаем и подключаем(using) пакет Nuget Microsoft.Extensions.DependencyInjection;
3.2. создаем сервисную коллекцию IServiceCollection services = new ServiceCollection();
3.3. регистрируем в этой севрисной коллекции интерфейс и используемый сервис, реализуемый от выбранного интрефейса
services.AddTransient<ILogService, SimpleLogService>();
3.3.1. дополнительно можно зарегистрировать классы которые используют в качестве входящего параметра зарегистрированные раннее интрефейс в конструкторе
services.AddTransient<Loger>();
3.4. создаем провайдер чтобы дальше получать с сервисной колекции необходимые сервисы
var serviceProvider = services.BuildServiceProvider();
3.5. получаем с провайдера необходимые сервисы
ILogService logService = serviceProvider.GetService<ILogService>();
3.5.1 получаем экземпляр класса которые зарегистрировали в сервисную коллекцию без использования конструктора в пункте 3.3.1
Logger logger = serviceProvider.GetService<Logger>();
3.6. используем полученный сервис, согласно контракту
logService.Write("Hello METANIT.COM");
