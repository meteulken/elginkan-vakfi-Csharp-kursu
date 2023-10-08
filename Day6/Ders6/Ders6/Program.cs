// See https://aka.ms/new-console-template for more information
Kare kr = new Kare(6);
kr.KareAlani();
kr = new Kare(7);
kr.KareAlani();

class Sekil
{
    public int kenar { get; set; }
    public int kisakenar { get; set; }
    public int uzunkenar { get; set; }

    public Sekil(int kenar) 
    {
        this.kenar = kenar;
     
    }
    public Sekil(int kisakenar,int uzunkenar) 
    {
        this.kisakenar = kisakenar;
        this.uzunkenar = uzunkenar;
    }
}

class Kare : Sekil
{
    public Kare(int kenar) : base (kenar)
    {

    }
    public void KareAlani()
    {
        int alan = kenar * kenar;
        Console.WriteLine(alan);
    }
}
class Dikdortgen : Sekil
{
    public Dikdortgen(int kisakenar,int uzunkenar) : base (kisakenar, uzunkenar) 
    { 
    
    }
    public void KareAlani()
    {
        int alan = uzunkenar * kisakenar;
        Console.WriteLine(alan);
    }
}