//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.

int arrayLenght = 6;
int arrayMaxValue = 1000;
int arrayMinValue = 100;
int count = 0;
int[] arrayInt = { };
arrayInt = ArrayIntGenerator(arrayLenght, arrayMaxValue, arrayMinValue);
for (int i = 0; i < arrayLenght; i++)
{
    if (arrayInt[i] % 2 == 0) count++;
}
Console.WriteLine($"Количество чётных чисел = {count}");

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