using System;

class Program
{
    
    static void Main(string[] args)
    {
        ax();
        Kullan.bx(4);
      
    }
    static void ax()
    {
        Console.WriteLine("selm");
    }
   
}
class Kullan
{

    static Kullan()
    {
        Console.WriteLine("first");
    }


    public static void bx(int t)
    {
        Console.WriteLine(t);
    }
    string  cx()
    {
        return "ver";
    }
    string dx(int p)
    {
        return p.ToString();
    }
}