// See https://aka.ms/new-console-template for more information

Console.WriteLine("Введите значение для переменной a:");
double a = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите значение для переменной b:");
double b = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите значение для переменной f:");
double f = Convert.ToDouble(Console.ReadLine());
        
if (a == 0)
{
    Console.WriteLine("Ошибка: деление на ноль невозможно.");
}
else
{
    double result = (a + b - f / a) + f * a * a - (a + b);
    Console.WriteLine($"Результат выражения: {result}");
}