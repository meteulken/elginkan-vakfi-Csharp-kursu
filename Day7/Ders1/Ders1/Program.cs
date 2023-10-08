
class Program
{     static void Main()
    {
        Deneme1 dn = new Deneme1();
        dn.x = 5;
        dn.y = 6;
        dn.A();
    }
}

class Deneme
{
    protected int _x, _y;
    public int x { get { return _x; } set { _x = value; } }
    public int y { get { return _y; } set { _y = value; } }

    protected int Topla(int a,int b) 
    {
        int toplam = _x + _y;
        return toplam;
    }
    
}

class Deneme1 : Deneme 
{
    public Deneme1()
    {


    }
    public int A()
    {
        return _x + _y;
    }
    public void Invoke()
    {
        Topla();
    }
}