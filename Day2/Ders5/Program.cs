using System;

Console.WriteLine("Hello, World!");

byte yas;
string medeni_durum;

Console.Write("Yas Bilgisi Giriniz :");
yas = Convert.ToByte(Console.ReadLine());

if(yas >= 18)
{
    Console.Write("Medeni Durum :");
    medeni_durum = Console.ReadLine().ToUpper();
    if(medeni_durum == "BEKAR")
        Console.WriteLine("Evliliğe elverişlidir...");

}
else if (yas < 18)
{
    Console.WriteLine("Evliliğe elverişli değildir...");   
}
else
{
    Console.WriteLine("Girilen Deger Uygun Degildir...");
}
