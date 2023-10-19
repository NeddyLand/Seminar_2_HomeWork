//  Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

System.Console.Write("Введите число: ");

string? input = Console.ReadLine();

if (int.TryParse(input, out int number))
{
    if (number < 100 || number >= 1000)
    {
        System.Console.WriteLine($"{number} -> не является трехзначным");
    }
    else
    {
        int secondChar = number % 100 / 10;
        System.Console.WriteLine($"{number} -> {secondChar}");
    }
}
else
{
    System.Console.WriteLine($"{input} не является числом.");
}