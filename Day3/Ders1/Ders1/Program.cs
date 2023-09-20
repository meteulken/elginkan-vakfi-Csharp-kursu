using System;

Console.Write("1 ile 4 arası sayi girniz :");

byte a = Convert.ToByte((Console.ReadLine()));

switch (a)
{
    case 1:
        Console.WriteLine("1 girdiniz.");
        break;
    case 2:
        Console.WriteLine("2 girdiniz.");
        break;
    case 3:
        Console.WriteLine("3 girdiniz.");
        break;
    case 4:
        Console.WriteLine("4 girdiniz.");
        break;
}