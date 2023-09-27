

class Program
{
    static void Main(string[] args)
    {
        B b = new B(2,4,6,8);
        b.Yazdir();

    }
    class A
    {
        public int a = 21;
        public int b;

        public A(int a,int b)
        {
            this.a = a;
            this.b = b;
        }
    }
    class B :A // miraslar temel sınıfın kurucu methodunu çalıştırır.
    {
        public int c;
        public int d;

        public B(int a,int b, int c, int d):base(a,b)
        {
            Console.WriteLine("Türetilmiş sınıfın kurucu methodu çalışır...");
            Console.WriteLine(this.a);
            Console.WriteLine(base.a);
        }
        public void Yazdir()
        {
            Console.WriteLine("{0} {1} {2} {3}",a,b,c,d);
        }
    }
  
}