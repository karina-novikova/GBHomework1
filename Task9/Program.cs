﻿// Задача 21 Напишите программу, которая принимает на вход координаты двух точек и 
// находит расстояние между ними в 3D пространстве.

double result;
int aX, aY, aZ;
int bX, bY, bZ;

Console.WriteLine("Введите посследовательность координат: ");
Console.Write("aX: ");
aX = Convert.ToInt32(Console.ReadLine());
Console.Write("aY: ");
aY = Convert.ToInt32(Console.ReadLine());
Console.Write("aZ: ");
aZ = Convert.ToInt32(Console.ReadLine());
Console.Write("bX: ");
bX = Convert.ToInt32(Console.ReadLine());
Console.Write("bY: ");
bY = Convert.ToInt32(Console.ReadLine());
Console.Write("bZ: ");
bZ = Convert.ToInt32(Console.ReadLine());

result = Math.Pow(bX - aX, 2) + Math.Pow(bY - aY, 2) + Math.Pow(bZ - aZ, 2);
result = Math.Sqrt(result);
result = Math.Round(result, 2);
Console.WriteLine(result);