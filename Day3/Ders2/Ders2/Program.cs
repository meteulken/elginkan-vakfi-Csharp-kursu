// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


Console.WriteLine("Toplama --> +");
Console.WriteLine("Çıkarma --> -");
Console.WriteLine("Çarpma --> *");
Console.WriteLine("Bölme --> /");

Console.Write("Operatörü giriniz: ");

char islem = Convert.ToChar(Console.ReadLine());

int a = 3;
int b = 4;

switch(islem)
{
    case '+':
        Console.WriteLine("Toplam={0}", a + b);
        break;
    case '-':
        Console.WriteLine("Toplam={0}", a - b);
        break;
    case '*':
        Console.WriteLine("Toplam={0}", a * b);
        break;
    case '/':
        Console.WriteLine("Toplam={0}", a / b);
        break;
    default:
        Console.WriteLine("Hatalı işlem seçildi.");
        break;
}   