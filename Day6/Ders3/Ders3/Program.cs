
class Program
{
    static void Main ()
    {
        Muhendis mh = new Muhendis(); 
        mh.getinfo();
    }
}

class Personel
{
    protected string tcKimlik = "214324322";
    protected string isim = "hasan deniz";
    
    public virtual void getinfo()
    {
        Console.WriteLine("İsim: {0}", isim);
        Console.WriteLine("TC Kimlik: {0}", tcKimlik);
    }
}
class Muhendis : Personel
{
    public string diplomano = "123123";
    public override void getinfo()
    {
        base.getinfo();
        Console.WriteLine("Diploma No: {0}", diplomano);
    }
}