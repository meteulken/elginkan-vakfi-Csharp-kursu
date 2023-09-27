
class Program
{
    static void Main(string[] args)
    {
        MyClass2 myc = new MyClass2();
        myc.topla();
       
       
    }
}
public class MyClass
{
    public MyClass()
    {
        Console.WriteLine("selam");
    }

    public void topla()
    {
        Console.WriteLine(3 + 5);
    }
    void cikar()
    {
        Console.WriteLine(3 - 5);
    }
    protected void kullan()
    {
        cikar();
    }
}
    class MyClass2:MyClass
    {
       void al()
        {
        kullan();
        topla();
        }
    }

   
    /*
     * public : her yerden ulaşabilir.
     * private : sadece tanımlandığı sınıfdan oluşur.
     * protected : hem tanımlandığı sınıftan hemde miras alan sınıftan ulaşabilir.
     * internal : aynı program içinden ulaşabilir.
     */
