
using Study6_Introduse_Scope;
using System.Diagnostics.Metrics;
using System;

// AddTransient
Model model1 = new Model();
Model model2 = new Model();
Model model3 = new Model();
Model model4 = new Model();

//model1.GetNumber();
//model2.GetNumber();
Console.WriteLine(model1.Number);
Console.WriteLine(model2.Number);
Console.WriteLine(model3.Number);
Console.WriteLine(model4.Number);


//AddSingletone
Model model11 = new Model();
Model model12 = model11;
Model model13 = model11;
Model model14 = model11;

Console.WriteLine(model11.Number);
Console.WriteLine(model12.Number);
Console.WriteLine(model13.Number);
Console.WriteLine(model14.Number);

//AddScope
// Используется Dispose и в потоках
//using (IServiceScope scope = serviceProvider.CreateScope())
//{// контекст scope
//	var counter1 = scope.ServiceProvider.GetService<ICounter>();
//	var counter2 = scope.ServiceProvider.GetService<ICounter>();
//	Console.WriteLine($"Counter1: {counter1?.Value}; Counter2: {counter2?.Value}");
//}

//}
