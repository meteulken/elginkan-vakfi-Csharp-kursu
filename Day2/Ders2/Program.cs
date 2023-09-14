using System;
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int a = 5;
int b = 3;

Console.Write("Bir sayi giriniz :");

a = Convert.ToInt32(Console.ReadLine());


if(a > b)
{
    Console.WriteLine("a > b ");
}
else
{
    Console.WriteLine("a < b");
}


