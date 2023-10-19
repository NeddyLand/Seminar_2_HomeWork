// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

System.Console.Write("Введите число: ");

string? input = Console.ReadLine();

if (int.TryParse(input, out int number))
{
    string numberString = Convert.ToString(number);
    char thirdChar;

    if (numberString.Length < 3)
    {
        System.Console.WriteLine($"{numberString} -> третьей цифры нет");
    }
    else if (number < 0)
    {
        thirdChar = input[3];
        System.Console.WriteLine($"{numberString} -> {thirdChar}");
    }
    else
    {
        thirdChar = input[2];
        System.Console.WriteLine($"{numberString} -> {thirdChar}");
    }
}
else
{
    System.Console.WriteLine($"{input} не является числом.");
}
