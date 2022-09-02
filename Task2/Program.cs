using System;

System.Console.WriteLine("Введите первое число: ");
string num1 = Console.ReadLine();
int num1Conv = int.Parse(num1);

System.Console.WriteLine("Введите второе число: ");
string num2 = Console.ReadLine();
int num2Conv = int.Parse(num2);

System.Console.WriteLine("Введите третье число: ");
string num3 = Console.ReadLine();
int num3Conv = int.Parse(num3);

int max = num1Conv;

if (num2Conv > num1Conv)
{
    max = num2Conv;
}
if (num3Conv>num2Conv)
{
    max = num3Conv;
}
System.Console.WriteLine("Максимальное из введенных чисел - " + max);