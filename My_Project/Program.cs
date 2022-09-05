
//Определение входного числа
Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());

//Получение квадрата входного числа
int result = number * number;
Console.WriteLine($"Квадрат чиcла {number} = {result}");

//Значок $ позволяет вписывать числа в строки

//Второй способ подсчёта квадрата числа. Здесь мы использовали библиотеку Math. Функция Pow позволяет
//возводить число в любую степень. Функция Convert делает преобразование данных. 

int result_2 = Convert.ToInt32(Math.Pow(number, 2));
Console.WriteLine($"Квадрат чиcла {number} = {result}");

