﻿
//Определение входного числа
Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());

//Получение квадрата входного числа
int result = number * number;
Console.WriteLine($"Квадрат чиcла {number} = {result}");

//Значок $ позволяет вписывать числа в строки

int result_2 = Convert.ToInt32(Math.Pow(number, 2));
Console.WriteLine($"Квадрат чиcла {number} = {result}");

