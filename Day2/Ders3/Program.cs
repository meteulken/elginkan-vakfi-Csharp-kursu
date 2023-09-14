using System;

double deger = 0;
string s = "Hava";

do
{
Console.Write("Hava Sicaklik Degerini Giriniz :");

deger = Convert.ToDouble(Console.ReadLine());

if(deger <= -5) 
    pM(" Asiri Soğuk");
else if (deger <= 0)
     pM(" Soğuk");
else if (deger <= 10)
     pM(" Az Soğuk");
else if (deger <= 20)
     pM(" Serin");
else if (deger <= 25)
     pM(" Sicak");
else if (deger <= 30)
     pM(" Çok Sicak");
else if (deger <= 40)
     pM(" Asiri Sicak");
else
    pM("Asiri Sicak");
} while (deger != 99);


void pM(string str)
{
    Console.WriteLine(s + str);
}