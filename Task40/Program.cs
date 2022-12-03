// Задача 40: Напишите программу, которая принимает на вход три числа
// и проверяет, может ли существовать треугольник со сторонами такой длины.
// Теорема о неравенстве треугольника: 
// каждая сторона треугольника меньше суммы двух других сторон.

Console.WriteLine("Введите три натуральных числа: ");
Console.Write("A:");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("B:");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("C:");
int num3 = Convert.ToInt32(Console.ReadLine());

bool Triangle(int a, int b, int c)
{
    return (a < b + c && b < a + c && c < a + b);
}

if (num1 > 0 && num2 > 0 && num3 > 0)
{
    bool result = Triangle(num1, num2, num3);
    Console.WriteLine(result
    ? $"Треугольник со сторонами {num1}, {num2}, {num3} может существовать"
    : $"Треугольника со сторонами {num1}, {num2}, {num3} не существует");
}
else
{
    Console.WriteLine("Ошибка! Введите натуральные числа");
}