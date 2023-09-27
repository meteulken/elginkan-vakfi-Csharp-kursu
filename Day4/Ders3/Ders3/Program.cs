
class Program
{
    static void Main(string[] args)
    {
        kokdurumu(1,2,1);
    }
    static string kokdurumu(int a,int b, int c)
    {
        double delta = Math.Pow(b,2) - 4 * a * c;

        kokler(a,b,c,delta);
        if(delta > 0)
        { return "kokler ciftdir";}
        else if (delta == 0)
        { return "kokler cift ve esittir"; }
        else
        { return "kokler sanaldir"; }
    }
    static void kokler(int a, int b, int c, double delta)
    {
        double birinci_kok = -b + Math.Sqrt(delta);
        double ikinici_kok = -b + Math.Sqrt(delta);
        Console.WriteLine($"{birinci_kok},{ ikinici_kok}");
    }
}