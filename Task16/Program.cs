﻿// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

int arrayLenght = 8;
int arrayMaxValue = 100;
int arrayMinValue = 1;
double resultDifference;
double minimalInArray = 0;
double maximalInArray = 0;
double[] arrayDoubleType = new double[arrayLenght];
for (int i = 0; i < arrayLenght; i++)
{
    arrayDoubleType[i] = new Random().NextDouble();
    arrayDoubleType[i] = arrayDoubleType[i] * (arrayMaxValue - arrayMinValue) + arrayMinValue;
    arrayDoubleType[i] = Math.Round(arrayDoubleType[i], 2);
    Console.Write(arrayDoubleType[i] + "; ");

    if (i == 0)
    {
        maximalInArray = arrayDoubleType[i];
        minimalInArray = arrayDoubleType[i];
    }
    if (arrayDoubleType[i] > maximalInArray) maximalInArray = arrayDoubleType[i];
    if (arrayDoubleType[i] < minimalInArray) minimalInArray = arrayDoubleType[i];
}
Console.WriteLine();
resultDifference = maximalInArray - minimalInArray;
Console.WriteLine($"Разница между максимальным и минимальным значениями:");
Console.WriteLine($"{maximalInArray} - {minimalInArray} = {resultDifference}");