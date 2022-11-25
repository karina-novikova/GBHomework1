// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.


double numberK1, numberB1;
double numberK2, numberB2;
double resultCoordinateX, resultCoordinateY;

Console.WriteLine("Укажите переменные для двух прямыx заданых уравнением:");
Console.WriteLine("y = k * x + b");

Console.Write("k1 = ");
numberK1 = Convert.ToDouble(Console.ReadLine());
Console.Write("b1 = ");
numberB1 = Convert.ToDouble(Console.ReadLine());
Console.Write("k2 = ");
numberK2 = Convert.ToDouble(Console.ReadLine());
Console.Write("b2 = ");
numberB2 = Convert.ToDouble(Console.ReadLine());

if (numberK1 != numberK2)
{
    resultCoordinateX = (numberB2 - numberB1) / (numberK1 - numberK2);
    resultCoordinateY = numberK2 * resultCoordinateX + numberB2;

    Console.WriteLine("Координаты точки пересечения:");
    Console.WriteLine($"X = {resultCoordinateX} ; Y = {resultCoordinateY}");
}
else if (numberB1 == numberB2) Console.WriteLine("Прямые совпадают");
else Console.WriteLine("Прямые параллельны");



