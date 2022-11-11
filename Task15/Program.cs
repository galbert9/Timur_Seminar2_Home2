// Задать случайный номер дня недели и определить, является ли он выходным

int a = new Random().Next(1,7);

Console.WriteLine($"Случайный номер недели " +a);

if (a > 5) Console.WriteLine("Выходной день");  
else Console.WriteLine("Рабочий день");