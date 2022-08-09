/*
Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/
int GetMaxNumber(int number1, int number2, int number3)
{
    int max = 0;

    if ((number1 > number2)&(number1 > number3))
    {
       max = number1;
    }
    else if ((number2 > number1)&(number2 > number3))
    {
         max = number2; 
    }  
    else if ((number3 > number1)&(number3 > number2))
    {
        max = number3;   
    }
    return max;

  }

Console.WriteLine("Введите число 1");
int number1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число 2");
int number2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число 3");
int number3 = int.Parse(Console.ReadLine());
int max = GetMaxNumber(number1, number2, number3);
Console.WriteLine($"max = {max}");