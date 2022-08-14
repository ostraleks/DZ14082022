/*Задача 19

Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

14212 -> нет

12821 -> да

23432 -> да*/


Console.Write("Введите пятизначное число ");
string inputNumber = Console.ReadLine();
int length = inputNumber.Length;
if (length != 5) Console.WriteLine($"это не пятизначное число");
else
{
int number = Convert.ToInt32(inputNumber);
if ((number / 10000 == number % 10) && (number / 1000 % 10 == number / 10 % 10)) Console.WriteLine($"{number} это полиндром");
else Console.WriteLine($"{number} это не полиндром");
}
