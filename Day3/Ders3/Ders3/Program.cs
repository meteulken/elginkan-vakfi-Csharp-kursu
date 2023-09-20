// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.WriteLine("Seçiniz 1-Boyut / 2-Boyut");

int secim = Convert.ToInt32(Console.ReadLine());
int sonuc;
int sonuc2;

switch(secim)
{
    case 1:
        Console.WriteLine("1-Kare / 2-Dikdortgen / 3-Daire");
        int secim2 = Convert.ToInt32(Console.ReadLine());
        switch(secim2)
        {
            case 1:
                Console.Write("Kare kenari giriniz :");
                sonuc = Convert.ToInt32(Console.ReadLine());
                sonuc2 = sonuc * sonuc;
                Console.WriteLine(sonuc + " Alani: " + sonuc2);
                break;
            case 2:
                Console.Write("Dikdortgen kenari giriniz :");
                 sonuc = Convert.ToInt32(Console.ReadLine());
                 sonuc2 = sonuc * sonuc;
                Console.WriteLine(sonuc + " Alani: " + sonuc2);
                break;
            case 3:
                Console.Write("Daire kenari giriniz :");
                 sonuc = Convert.ToInt32(Console.ReadLine());
                 sonuc2 = sonuc * 3;
                Console.WriteLine(sonuc + " Alani: " + sonuc2);
                break;
        }
        break;
    case 2:
        Console.WriteLine("1-Kare / 2-Dikdortgen / 3-Daire");
        int secim3 = Convert.ToInt32(Console.ReadLine());
        switch (secim3)
        {
            case 1:
                Console.Write("Kare kenari giriniz :");
                sonuc = Convert.ToInt32(Console.ReadLine());
                sonuc2 = sonuc * sonuc;
                Console.WriteLine(sonuc + " Alani: " + sonuc2);
                break;
            case 2:
                Console.Write("Dikdortgen kenari giriniz :");
                sonuc = Convert.ToInt32(Console.ReadLine());
                sonuc2 = sonuc * sonuc;
                Console.WriteLine(sonuc + " Alani: " + sonuc2);
                break;
            case 3:
                Console.Write("Daire kenari giriniz :");
                sonuc = Convert.ToInt32(Console.ReadLine());
                sonuc2 = sonuc * 3;
                Console.WriteLine(sonuc + " Alani: " + sonuc2);
                break;
        }
        break;
}