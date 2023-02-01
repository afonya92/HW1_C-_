// # Задача 2. Напишите программу, которая на вход принимает два числа и выдаёт, какое число больше, а какое меньше.

Console.Write("Введите первое число: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = int.Parse(Console.ReadLine());

if(a < b)
{
    Console.WriteLine($"минимальное {a}, максимальное {b}");
}
else 
{
    Console.WriteLine($"максимальное {a}, минимальное {b}");
}




// Задача 4. Напишите программу, которая принимает нп вход три числа и выдает максимальное из этих чисел.

Console.Write("Введите первое число: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = int.Parse(Console.ReadLine());
Console.Write("Введите третье число: ");
int d = int.Parse(Console.ReadLine());

int max = a;

if(a > max) max = a;
if(b > max) max = b;
if(d > max) max = d;

Console.WriteLine($"max = {max}");




// Задача 6. Напишите программу, которая на вход принимает число и выдает, является ли число четным(делится ли оно на два без остатка).

int b = 2;
Console.WriteLine("Введите число");
if(int.TryParse(Console.ReadLine(), out int a))
{
    if(a % b == 0)
    {
        Console.Write("Четное");
    }
    else
    {
         Console.Write("Не четное");
    }
}
else
{
    Console.WriteLine("Вы ввели не вверное значение");
}
 




 // Задача 8. Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

int i = 1;
int a;
bool not = true;

Console.WriteLine("Введите число:");
a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Чётные числа от 1 до " + a);
while (i <= a)
{
    if (i % 2 != 1)
    {
        Console.Write(i + ", ");
        not = false;
    }
    i++;
}

if (not)
{
    Console.WriteLine("Нет чётных чисел!");
}