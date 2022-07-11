//введите три числа и выведите на экран значение суммы и произведения этих чисел

double firstValue, secondValue, thirdValue;
Console.WriteLine("Введите первое число");
firstValue = double.Parse(Console.ReadLine());

Console.WriteLine("Введите второе число");
secondValue = double.Parse(Console.ReadLine());

Console.WriteLine("Введите третье число");
thirdValue = double.Parse(Console.ReadLine());

double sumResult = firstValue + secondValue + thirdValue;
Console.WriteLine("Сумма трёх чисел = " + sumResult);

double multResult = firstValue * secondValue * thirdValue;
Console.WriteLine("Произведение трёх чисел = " + multResult);


