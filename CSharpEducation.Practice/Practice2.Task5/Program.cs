// See https://aka.ms/new-console-template for more information

Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
        
if (a<b)
{
    Console.WriteLine($"Число {a} меньше числа {b}");
}
if (b<a)
{
    Console.WriteLine($"Число {b} меньше числа {a}");
}
if (a == b)
{
    Console.WriteLine($"Число {a} равно числу {b}");
}