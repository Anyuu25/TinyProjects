//напишите простой конвертер валют (без возможности динамического выбора валюты пользователем). Валюты заданы хардкодом и не изменяются. Тип валют на выбор программиста.
//перевод долларов в рубли, в юани

double UsdToRub = 56.71;
double UsdToCny = 6.62;
double USD;

Console.WriteLine("Введите сумму в USD");
USD = double.Parse (Console.ReadLine());

Console.WriteLine(USD + " USD в RUB = " + USD * UsdToRub);
Console.WriteLine(USD + " USD в Yuan = " + USD * UsdToCny);
