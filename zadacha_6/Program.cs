﻿/*
Задача 6: Напишите программу, которая на вход принимает число и выдаёт, 
является ли число чётным (делится ли оно на два без остатка).

4 -> да
-3 -> нет
7 -> нет
*/
string DetectOddNumber(int number)
{
    string answer;
    if (number % 2 > 0)
    {
       answer = "нет";
    }
    else 
    {
         answer = "да";
    }  
    return answer;

  }

Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine());
string answer = DetectOddNumber(number);
Console.WriteLine(answer);