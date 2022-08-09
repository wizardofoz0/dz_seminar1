/*
Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, 
а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/
int GetMaxNumber(int number1, int number2)
{
    int max;
    if (number1 > number2) 
    {
    max = number1;
    }
    else 
    {
    max = number2;   
    }
    return max;
}

Console.WriteLine("Введите число 1");
int number1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число 2");
int number2 = int.Parse(Console.ReadLine());
int max = GetMaxNumber(number1, number2);
Console.WriteLine($"max = {max}");