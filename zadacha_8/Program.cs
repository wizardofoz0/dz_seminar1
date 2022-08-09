/*Задача 8: Напишите программу, которая на вход принимает число (N), 
а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8
*/

int [] OddNumber(int maxnumber)
{   int size = maxnumber/2;
    int [] numbers = new int[size];
    int S = 0;
  //  Console.WriteLine($" size = {size}");
    for (int i = 0; i < size; i++) 
    {
        S = S + 2;
        numbers[i] = S;
      //  Console.WriteLine($" i = {i}");
      //  Console.WriteLine($" numbers = {numbers[i]}");
    }
    return numbers;
  }

Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine());
int[] numbers = OddNumber(number);
for (int i = 0; i < numbers.Length; i++) 
    {
        Console.WriteLine(numbers[i]);
    }

