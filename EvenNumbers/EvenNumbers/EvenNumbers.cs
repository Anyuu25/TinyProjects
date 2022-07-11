//напишите программу, проверяющую число, введённое с клавиатуры, на чётность

int number;

Console.WriteLine("Введите число для проверки на чётность");

number = int.Parse(Console.ReadLine());

if (number % 2 == 0)
{
    Console.WriteLine("Число чётное");
}
else
{
    Console.WriteLine("Число нечётное");
}
