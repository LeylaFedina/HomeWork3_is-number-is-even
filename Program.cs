/*
Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
4 -> да
-3 -> нет
7 -> нет
*/

Console.Clear();
Console.WriteLine("Введите значение : ");
int userNumber = Convert.ToInt32(Console.ReadLine());

if (userNumber % 2 ==0)
{
    Console.WriteLine("данное число является четным");
}
else
{
    Console.WriteLine("данное число является нечетным");
}