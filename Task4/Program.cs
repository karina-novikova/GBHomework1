//Напишите программу, которая на вход принимает число (N),
//а на выходе показывает все чётные числа от 1 до N.

int i = 1;
bool dec = true;
Console.WriteLine("Введите число:");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Чётные числа от 1 до " + num);
while (i <= num){
    if (i % 2 != 1){
        Console.Write(i + ", ");
        dec = false;
    }
i++;
}
if (dec)
{
Console.WriteLine("Нет чётных чисел!");
}