//  Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
int minNumber = 100;
int maxNumber = 999;

int number = new Random().Next(minNumber, maxNumber + 1);
string numberString = Convert.ToString(number);

char secondChar = numberString[1];

System.Console.WriteLine($"{numberString} -> {secondChar}");