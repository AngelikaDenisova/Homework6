﻿Console.WriteLine("Введите число b1 ");
double b1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число k1 ");
double k1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число b2 ");
double b2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число k2 ");
double k2 = Convert.ToInt32(Console.ReadLine());

double x = -((b2 - b1) / (k2 - k1));

Console.WriteLine(x);

double y = k1 * x + b1;

Console.WriteLine(y);
