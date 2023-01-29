using Study;
using Study.LogServises;

GreenLogServise greenLogServise = new GreenLogServise();
LogSimpleServise logSimpleServise = new LogSimpleServise();
RedLogServise redLogServise = new RedLogServise();
Loger loger = new Loger(redLogServise);

loger.Log("Hello tem kapchi");