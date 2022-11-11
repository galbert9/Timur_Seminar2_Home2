// Найти 3-ю цифру заданного числа или сообщить отсуствие
Console.WriteLine("Ввести число  не более 1,000,000");
int b = Convert.ToInt32 (Console.ReadLine());

double d = Math.Log10(b);

if (d < 2) Console.WriteLine("Третьей цифры нет");
else if (d < 3) Console.WriteLine("Третья цифра = " +b%10);
else if (d < 4) Console.WriteLine("Третья цифра = " +b%100/10);
else if (d < 5) Console.WriteLine("Третья цифра = " +b%1000/100);
else if (d < 6) Console.WriteLine("Третья цифра = " +b%10000/1000);







