using System.Runtime.Intrinsics.X86;

namespace Learning_C_;

class Poo
{
    private int x;


    public void SetX(int x)
    {
        if (x < 1)
        {
            this.x = 1;
            return;
        }
        if (x > 5)
        {
            this.x = 5;
            return;
        }
        this.x = x;
    }

    public int GetX()
    {
        return x;
    }

    // это свойство (property) -- быстро генерируется через propfull
    private int y;
    public int Y
    {
        get // это аксессор
        {
            return y;
        }
        set
        {
            if (value < 1)
            {
                value = 1;
                return;
            }
            if (value > 5)
            {
                value = 5;
                return;
            }
            y = value; // это ключевое слово, необходимое для взаимодействия с set
        }
    }

    public int Z { get; set; } // это автоматическое свойство без логики.


}

class GetSet
{
    public static void Get_Set()
    {
        Poo poo = new Poo();
        poo.SetX(4);
        Poo poo2 = new();
        poo2.SetX(10);

        int x = poo.GetX();
        poo.Y = -20; // так происходит взаимодействие с аксессором set
        int y = poo.Y; // так с аксессором get
        poo.Z = 400;
        int z = poo.Z;
        int x2 = poo2.GetX();

        Console.WriteLine("X: " + x);
        Console.WriteLine("Y: " + y);
        Console.WriteLine("Z: " + z);
        Console.WriteLine("X2: " + x2);
    }
}