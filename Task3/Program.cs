// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

System.Console.Write("Введите цифру дня недели: ");

string? input = Console.ReadLine();

if (int.TryParse(input, out int number))
{
    if (number > 0 && number <= 7)
    {
        if (number >= 6)
        {
            System.Console.WriteLine($"День недели {number} является выходным? -> Да");
        }
        else
        {
            System.Console.WriteLine($"День недели {number} является выходным? -> Нет");
        }
    }
    else
    {
        System.Console.WriteLine($"{number} -> Такого дня недели нет");
    }
}
else
{
    System.Console.WriteLine($"{input} не является цифрой.");
}