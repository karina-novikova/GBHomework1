//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или 
// сообщает, что третьей цифры нет.

Console.Write("Введите любое число: ");
int count;
int num = Convert.ToInt32(Console.ReadLine());
int numDigit = NumberDigit(num);// Пробуем функцию/метод.
if (numDigit <= 2)
{
Console.WriteLine("Третьей цифры нет");
}
else
{
if (numDigit > 3)
{
num = num / Convert.ToInt32(Math.Pow(10, numDigit - 3)); // немного Math
}
num = num % 10;
Console.WriteLine($"Третья цифра введённого числа: {num}");
 }

int NumberDigit(int number)
{
    count = 0;
    while (number > 0)
    {
        number = number / 10;
        count++;
    }
    return count;
}