using Microsoft.Extensions.DependencyInjection;
using Study4;
using Study4.Domain;
using Study4.Servises;
// создаю сервисную коллекцию
IServiceCollection services = new ServiceCollection();
// регистрируем в этой серисной коллекции интрефейс используемый сервис, реализуемый от выбранного сервиса
services.AddTransient<ITimeService, ShortTimeService>().AddTransient<TimeMessage>();
// создаем провайдер для получения сервисов
IServiceProvider serviceProvider = services.BuildServiceProvider();
// получаем с провайдера необходимые сервисы
TimeMessage timeMessage = serviceProvider.GetService<TimeMessage>();
//
Console.WriteLine(timeMessage.GetTime());
