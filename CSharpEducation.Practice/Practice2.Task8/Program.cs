namespace Practice2.Task8;

internal abstract class Program
{
    static void Main()
    {
        // Объявляем три переменные для хранения введенных значений
        int a, c;

        // Выводим сообщение для пользователя
        Console.WriteLine("Введите три числа:");

        // Считываем введенные значения и преобразуем их в целые числа
        a = int.Parse(Console.ReadLine() ?? string.Empty);
        var b = int.Parse(Console.ReadLine() ?? string.Empty);
        c = int.Parse(Console.ReadLine() ?? string.Empty);

        // Проверяем, есть ли среди введенных чисел хотя бы две равные
        if (a == b || b == c || a == c)
        {
            // Если есть, увеличиваем все три числа на 5
            a += 5;
            b += 5;
            c += 5;

            // Выводим результат
            Console.WriteLine($"Результат: a = {a}, b = {b}, c = {c}");
        }
        else
        {
            // Если равных чисел нет, выводим сообщение
            Console.WriteLine("Равных чисел нет");
        }
    }
}