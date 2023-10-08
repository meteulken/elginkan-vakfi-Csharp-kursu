using System;

class Araba
{
    public int MotorGucu { get; set; }
    public string Marka { get; set; }

    public Araba(int motorgucu, string marka)
    {
        this.MotorGucu = motorgucu;
        this.Marka = marka;
    }

    public virtual void OzellikGoster()
    {
        Console.WriteLine("Marka: {0}, Motor Gücü: {1}", Marka, MotorGucu);
    }
}

class Limuzin : Araba
{
    public int Uzunluk { get; set; }

    public Limuzin(int motorgucu, string marka, int uzunluk) : base(motorgucu, marka)
    {
        this.Uzunluk = uzunluk;
    }

    public override void OzellikGoster()
    {
        if (MotorGucu > 7000)
        {
            Console.WriteLine("Exclusive");
        }
        else
        {
            Console.WriteLine("Premium");
        }
    }
}

class Program
{
    static void Main()
    {
        Limuzin limuzin = new Limuzin(200, "Limuzin", 10);
        limuzin.OzellikGoster();
    }
}
