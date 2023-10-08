
Kitap kt = new Kitap();



public class BaseClass
{
    public string renk;
    public string marka;
    private string serino;
    
    public void SeriNoBelirle()
    {
        serino = "asadasd";
    }
    public virtual void GosterBaseBilgileri()
    {
        Console.WriteLine("renk :" + renk);
        Console.WriteLine("marka :"+marka);
        Console.WriteLine("Seri No :" + serino);

    }
    class Kitap : BaseClass
    {
        public string kitapismi;
        public string yazarismi;
        public string isim;

        public void KitapBilgileri()
        {
            GosterBaseBilgileri();
            Console.WriteLine("Kitap ismi :"+kitapismi);
            Console.WriteLine("Yazar ismi :" + yazarismi);
            Console.WriteLine("isim : "+isim);
        }
        public override void GosterBaseBilgileri()
        {
            base.GosterBaseBilgileri ();
            Console.WriteLine("renk :" + renk);
            Console.WriteLine("marka :" + marka);
            Console.WriteLine("Seri No :" + serino);

        }
    }
}