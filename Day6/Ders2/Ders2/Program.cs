

class Program
{
    static void Main()
    {
        A2 a2 = new A2();
        A2 a22 = new A2("bbbb");
    }
    class A1
    {
       public A1()
       {
           Console.WriteLine("A2 nesnesinden a2 oluştuğundan base ifadesinden dolayı ekrana yazıldı.");
       }
       public A1(string x)
       {
            Console.WriteLine("A2 nesnesinden a22 oluştuğunda parametresi base ifadesinden dolayi");
       }
    }
    class A2 : A1
    {
        public A2() : base()
        {
           
        }
        public A2(string x) : base(x)
        {
        
        }
    }
}