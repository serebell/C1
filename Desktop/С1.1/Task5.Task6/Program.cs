﻿//Задача 6: 
//Напишите программу, 
//которая на вход принимает число и выдает,
// является ли число четным (делится ли оно на два без остатка).
//4 -> да
//-3 -> нет
//7 -> нет

Console.WriteLine("Введите число: ");
int Number = Convert.ToInt32(Console.ReadLine());

int remDiv = Number % 2;

if (remDiv == 0)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}