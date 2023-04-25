// Console.WriteLine("input number:");
// int num = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine ($"You input {{{(num)}}} number"); 

// Task1. Запросить число и вывести его квадрат.

// Console.WriteLine("input number");
// int num = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"Quad of {num} -> {num*num}");

// Task2. Является ли первое число квадратом второго?

// Console.WriteLine("input first number");
// int num = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("input second numder");
// int num2 = Convert.ToInt32(Console.ReadLine());

// if(num == num2*num2)
// {
//     Console.WriteLine($"{num} является квадратом {num2}");
// }
// else
// Console.WriteLine($"{num} не является квадратом {num2}");

// Task3. Напишите програма которая принимает на вход число N. На выходе получаем последовательность от -N до N.

// Console.WriteLine ("input N");
// int n = Convert.ToInt32(Console.ReadLine());

// if(n<0) Console.Write("invalid input N");

// int Count = n*(-1);
// while(Count <= n)
// {
//     Console.Write(Count+" ");
//     Count++;
// }

// Task 4. На вход принимаем трехзначенное число. Вывести последнюю цифру данного числа.

Console.WriteLine ("input three-digit number");
int n = Convert.ToInt32(Console.ReadLine());

int ed = n % 10;
Console.WriteLine($"Last digit of {n} -> {ed}");