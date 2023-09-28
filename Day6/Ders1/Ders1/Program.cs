using System;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        A3 a3 = new A3();
        a3.meslekNe();
    }
    class A1
    {
        public void AdinNe()
        {
            Console.WriteLine("Adiniz nedir?");
        }
    }

    class A2 : A1
    {
        public void yasKac()
        {
            Console.WriteLine("Yasiniz kac?");
            base.AdinNe();
        }
    }

    class A3 : A2
    {
        public void meslekNe()
        {
            Console.WriteLine("Mesleğiniz nedir?");
            base.yasKac();
        }
    }
}