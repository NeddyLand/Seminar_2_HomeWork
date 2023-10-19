// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

System.Console.Write("Введите число: ");

string? input = Console.ReadLine();

if (int.TryParse(input, out int number))
{
    if (number / 100 == 0)
    {
        System.Console.WriteLine($"{input} -> третьей цифры нет");
    }
    else
    {
        while (number < -1000 || number > 1000)
        {
            number /= 10;
        };

        int thirdChar = number % 10;
        if (thirdChar < 0)
        {
            thirdChar *= -1;
        }
        System.Console.WriteLine($"{input} -> {thirdChar}");
    }
}
else
{
    System.Console.WriteLine($"{input} не является числом.");
}
