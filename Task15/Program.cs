//Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

int arrayLenght = 8;
int arrayMaxValue = 1000;
int arrayMinValue = 100;
int sum = 0;
int[] arrayInt = { };
arrayInt = ArrayIntGenerator(arrayLenght, arrayMaxValue, arrayMinValue);
for (int i = 1; i < arrayLenght; i += 2)
{
    sum += arrayInt[i];
}

Console.WriteLine($"Сумма чисел = {sum}");


int[] ArrayIntGenerator(int lenght, int maxValue, int minValue) // генератор рандомных чисел для одномерного массива
{
int[] arrayInt = new int[lenght];
for (int i = 0; i < lenght; i++)
{
    arrayInt[i] = new Random().Next(minValue, maxValue);
    Console.Write(arrayInt[i] + "; ");
}
Console.WriteLine();
return arrayInt;
}