// See https://aka.ms/new-console-template for more informati
class Program
{
    static void Main(string[] args)
    {
        Hesapla hes = new Hesapla();
        hes.sayi1 = 2;
        hes.sayi2 = 5;

        Console.WriteLine(hes.topla());
        Console.WriteLine(hes.topla2(8, 9));
    }
}
class Hesapla
{
    public int sayi1;
    public int sayi2;
    public int sayi3;
    public int sayi4;

    public Hesapla(int sayi3,int sayi4)
    {
        this.sayi3 = sayi3;
        this.sayi4 = sayi4;
    }
    
    public int topla()
    {
        return sayi1 + sayi2;
    }
    public int topla2(int a,int b)
    {
        return a + b;
    }
}