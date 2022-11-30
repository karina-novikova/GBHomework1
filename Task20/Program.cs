//Задача 66: Задайте значения M и N.
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
int m, n;
Console.Write("Введите значение M: ");
m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение N: ");
n = Convert.ToInt32(Console.ReadLine());

int SumRange(int start, int end)
{
    int sum = 0;
    if (start < end) sum = start + end + SumRange(start + 1, end - 1);
    else if (start == end) sum = end;
    return sum;
}
Console.WriteLine(SumRange(m, n));
   