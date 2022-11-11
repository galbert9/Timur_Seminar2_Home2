// 3-x значное число на входе, найти вторую цифру этого числа

// Локальная задача: найти случайное число в диапазоне от 1 до 10
// с помощью цикла

// int a = new Random().Next(1,10);
// Console.WriteLine($"Случайное число {a}");
// int i = 1;
// if (i < a)
// while (i < 10)
// {
// if (i > a) break;
// i = i +1;
// }
// Console.WriteLine($"{i-1}");

// Находим 1-ю цмфру случайного числа

int a = new Random().Next(100,1000);
Console.WriteLine($"Случайное число {a}");
int b = a / 10 % 10;

int i = 100;
if (i < a)
while (i < 1000)
{
if (i > a) break;
i = i +100;
}
//Console.WriteLine("Первая цифра случайного числа " +(i-100)/100);

// Находим 2-ю цмфру случайного числа

//Console.WriteLine($"{b}");

int i2 = 1;
if (i2 < b)
while (i2 < 10)
{
if (i2 >= b) break;
i2 = i2 +1;
}
Console.WriteLine("Вторая цифра случайного числа " +(i2));
 



