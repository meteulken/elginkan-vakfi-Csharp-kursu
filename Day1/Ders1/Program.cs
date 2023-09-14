using System;
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// Path: Ders1\Program.cs

int sayi1 = 0;
int sayi2 = 0;
int secim = 0;

Console.WriteLine("Hesaplama Programı : \n 1- Toplama \n 2- Cikarma \n 3- Carpma \n 4- Bolme");

Console.Write("Secim Yapiniz :");

secim = Convert.ToInt32(Console.ReadLine());

Console.Write("Birinci Sayiyi giriniz: ");
sayi1 = Convert.ToInt32(Console.ReadLine());

Console.Write("İkinci Sayiyi giriniz: ");
sayi2 = Convert.ToInt32(Console.ReadLine());

    switch(secim)
    {
        case 1:
            Console.WriteLine("Toplam :" + (sayi1+sayi2));
            break;
        case 2:
            Console.WriteLine("Cikarma :" + (sayi1-sayi2));
            break;
        case 3:
            Console.WriteLine("Carpma :" + (sayi1*sayi2));
            break;
        case 4:
            Console.WriteLine("Bölme :" + (sayi1/sayi2));
            break;
        default:
            Console.WriteLine("Hatali Secim");
            break;
    }
