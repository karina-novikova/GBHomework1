//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и
// возводит число A в натуральную степень B.
int result;
int numberA, numberB;

Console.WriteLine("Для возведения числа А в натуральную степень В -  A^B");
Console.Write("Введите число A: ");
numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
            numberB = Convert.ToInt32(Console.ReadLine());

            result = numberA;

            for (int i = 2; i <= numberB; i++)
            {
                result *= numberA;
            }

            Console.WriteLine($"{numberA}^{numberB} = {result}");