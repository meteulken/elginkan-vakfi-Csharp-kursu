
class Program
{
    static void Main()
    {
        AkilliTelefon AKa = new AkilliTelefon();
        AkilliTelefonTemelOzellikler ab = new AkilliTelefon();

    }
}
abstract class AkilliTelefonTemelOzellikler
{
    public abstract void fotorafCek();
    public abstract void videoCek();
    public virtual void CocukKilidi()
    {
        Console.WriteLine("Cocuk kilidi aktif");
    }
    public virtual void GPSIzleme()
    {
        Console.WriteLine("GPS izleme aktif");
    }
    public void Kapan()
    {
        Console.WriteLine("Kapaniyor");
    }

}
class AkilliTelefon : AkilliTelefonTemelOzellikler
{
    public override void fotorafCek()
    {
        Console.WriteLine("Fotoraf çekme");
    }

    public override void videoCek()
    {
        Console.WriteLine("video cekiliyor");
    }
    public virtual void CocukKilidi()
    {
        base.CocukKilidi();
    }
    public new void Kapan()
    {

    }
}