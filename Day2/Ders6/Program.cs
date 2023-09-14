
using System;
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int secim = 0;

Console.Write("***********************");
Console.Write("\n* Alan Hesaplama.    * \n* Kare       -> 1    * \n* Dikdortgen -> 2    *\n* Daire      -> 3    *\n");
Console.Write("***********************");

Console.Write("\nSecim Yapiniz :");

secim = Convert.ToInt32(Console.ReadLine());

if(secim == 1)
{
    Console.Write("Kenar :");
    double kenar = Convert.ToDouble(Console.ReadLine());
    double alan = kenar * kenar;
    Console.WriteLine("Kenarı {0} olan karenin alanı = {1}",kenar,alan);
}
else if (secim == 2)
{
    Console.Write("Kısa Kenar :");
    double kenar = Convert.ToDouble(Console.ReadLine());
    Console.Write("Uzun Kenar :");
    double kenar2 = Convert.ToDouble(Console.ReadLine());
    double alan = kenar * kenar2;
    Console.WriteLine("Kısa kenarı {0} ve uzun kenarı {1} olan dikdörtgenin alanı = {2}",kenar,kenar2,alan);
}

else if (secim == 3)
{
    Console.Write("Yarı Cap :");
    double r = Convert.ToDouble(Console.ReadLine());
    double alan = Math.PI * r * r;
    Console.WriteLine("Yarı Çapı {0} olan dairenin alanı {1}",r,alan);
}
else
{
    Console.WriteLine("Secilen deger uygun degğildir");
}