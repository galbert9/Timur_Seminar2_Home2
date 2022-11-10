// 3-x значное число на входе, на выходе дать вторую цифру
int a = new Random().Next(100,1000);
Console.WriteLine($"Случайное число {a}");
int b = a/10;
int c = b % 10;
Console.WriteLine($"{c}");