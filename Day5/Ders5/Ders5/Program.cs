
class Program
{
    static void Main(string[] args)
    {
        int x = 3;
        int y = 4;
        hesapla.carp(x, y);

    }
    public static class hesapla
    {
        public static void topla(int sayi1, int sayi2)
        {
            int toplam = sayi1 + sayi2;
        }
        public static void carp(int sayi1, int sayi2)
        {
            int carpim = sayi1 * sayi2;
            Console.WriteLine(carpim);
        }
        public static void fark(int sayi1, int sayi2)
        {
            int carpim = sayi1 - sayi2;
        }
    }
}