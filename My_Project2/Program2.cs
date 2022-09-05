//Ввод первоначальных данных
Console.WriteLine("Введите первое число ");
int number1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число ");
int number2 = int.Parse(Console.ReadLine());

//Записываем частное этих чисел в отдельную переменную
int divide = number1 / number2;


//Console.WriteLine($"Частное двух чисел равно {divide}");
if (number2 == divide)
{
    Console.WriteLine("Да, первое число является квадратом второго");
}
else
{
    Console.WriteLine("Нет, первое число не является квадратом второго");
}

