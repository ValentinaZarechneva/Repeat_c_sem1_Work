// Задача 2: Напишите программу, 
// которая на вход принимает два числа и 
// выдаёт, какое число большее, а какое меньшее.

Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число: ");
int b = Convert.ToInt32(Console.ReadLine());

if (a > b)
{
    Console.Write(a);
    Console.WriteLine("большее число");
    Console.Write(b);
    Console.WriteLine("меньшее число");
}
else if(b > a) 
{
    Console.WriteLine(b);
    Console.WriteLine("большее число");
    Console.WriteLine(a);
    Console.WriteLine("меньшее число");
}
else if(a == b)
{
    Console.WriteLine("Значение чисел равно");
}
