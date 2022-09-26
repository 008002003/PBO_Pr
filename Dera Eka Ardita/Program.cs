using System.Runtime;
using System.Runtime.CompilerServices;

namespace TugasPBOPR1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vga Vga1 = new Vga("Vga Nvidia, dan Processor Core i5");
            Vga Vga2 = new Vga("Vga Vga AMD, dan Processor ryzen");

            Laptop Laptop1 = new Vivobook("Asus", "Vivobook", Vga1);
            Laptop1.LaptopDinyalakan();
            Laptop1.MatikanMesin();
            Console.WriteLine(Laptop1.Vga.merk);
            Console.WriteLine();

            Laptop Laptop2 = new IdeaPad("Lenovo", "IdeaPad", Vga2);
            Laptop2.LaptopDinyalakan();
            Laptop2.MatikanMesin();
            ((IdeaPad)Laptop2).BermainGame();
            Console.WriteLine(Laptop2.Vga.merk);
            Console.WriteLine();

            Laptop predator = new Predator("Asus", "Predator", Vga2);
            predator.LaptopDinyalakan();
            predator.MatikanMesin();
            ((Predator)predator).Ngoding();
            Console.WriteLine();

        }
    }
}

class Vga
{
    public string merk;
    public Vga(string merk)
    {
        this.merk = merk;
    }
}

class AMD : Vga
{
    public AMD(string merk) : base(merk)
    {
        merk = "AMD";
    }
}

class Bridgestone : Vga
{
    public Bridgestone(string merk) : base(merk)
    {
        merk = "Bridgestone";
    }
}
class Laptop
{
    public string Merk;
    public string Tipe;
    public Vga Vga;

    public Laptop(string merk, string tipe, Vga Vga)
    {
        this.Merk = merk;
        this.Tipe = tipe;
        this.Vga = Vga;
    }

    public void LaptopDinyalakan()
    {
        Console.WriteLine($"Laptop {this.Merk} bertipe {this.Tipe} menyala");
    }

    public void MatikanMesin()
    {
        Console.WriteLine($"Laptop {this.Merk} bertipe {this.Tipe} mati");
    }
}

class IdeaPad : Asus
{
    public IdeaPad(string merk, string tipe, Vga Vga) : base("Ideapad", tipe, Vga)
    {
    }

    public void BermainGame()
    {
        Console.WriteLine($"Laptop {this.Merk} bertipe {this.Tipe} sedang memainkan game");
    }
}

class Vivobook : Asus
{
    public Vivobook(string merk, string tipe, Vga Vga) : base(merk, "Vivobook", Vga)
    {
    }

}

class ZenBook : Asus
{
    public ZenBook(string merk, string tipe, Vga Vga) : base(merk, "ZenBook", Vga)
    {
    }

}

class Asus : Laptop
{
    public Asus(string merk, string tipe, Vga Vga) : base("Asus", tipe, Vga)
    {
    }

}

class Ayla : Laptop
{
    public Ayla(string merk, string tipe, Vga Vga) : base(merk, "Ayla", Vga)
    {
    }

}

class Lenovo : Laptop
{
    public Lenovo(string merk, string tipe, Vga Vga) : base(merk, "Lenovo", Vga)
    {
    }

}

class Acer : Laptop
{
    public Acer(string merk, string tipe, Vga Vga) : base("Acer", tipe, Vga)
    {
    }

}

class MSI : Laptop
{
    public MSI(string merk, string tipe, Vga Vga) : base(merk, "MSI", Vga)
    {
    }

}

class Predator : Laptop
{
    public Predator(string merk, string tipe, Vga Vga) : base(merk, "Predator", Vga)
    {
    }

    public void Ngoding()
    {
        Console.WriteLine($"Ctak Ctak Ctak error lagi!!!");
    }

}
class asus : Laptop
{
    public asus(string merk, string tipe, Vga Vga) : base("asus", tipe, Vga)
    {
    }

}

