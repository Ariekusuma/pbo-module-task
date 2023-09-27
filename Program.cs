
class Processor
{
    public string merk;
    public string tipe;
    public Processor (string merk, string tipe)
    {
        this.merk = merk;
        this.tipe = tipe;
    }
}

class Intel : Processor
{
    public Intel(string tipe) : base("Intel", tipe)
    {
    }
}

class CoreI3 : Intel
{
    public CoreI3() : base("Core i3")
    {
    }
}

class CoreI5 : Intel
{
    public CoreI5() : base("Core i5")
    {
    }
}

class CoreI7 : Intel
{
    public CoreI7() : base("Core i7")
    {
    }
}

class AMD : Processor
{
    public AMD(string tipe) : base("AMD", tipe)
    {
    }
}

class Ryzen : AMD
{
    public Ryzen() : base("RYZEN")
    {
    }
}

class Athlon : AMD
{
    public Athlon() : base("ATHLON")
    {
    }
}
class Vga
{
    public string merk;
    public Vga (string merk)
    {
        this.merk = merk;
    }
}

class Nvidia : Vga
{
    public Nvidia() : base("Nvidia")
    {
    }
}

class amd : Vga
{
    public amd() : base("AMD")
    {
    }
}

class Laptop
{
    public string merk;
    public string tipe;
    public string vga;
    public string processor;
    public Laptop(string merk, string tipe, string vga, string processor)
    {
        this.merk = merk;
        this.tipe = tipe;
        this.vga = vga;
        this.processor = processor;
    }

    public void LaptopDinyalakan()
    {
        Console.WriteLine($"Laptop {merk} {tipe} menyala");
    }
    public void LaptopDimatikan()
    {
        Console.WriteLine($"Laptop {merk} {tipe} mati");
    }

    public void spesifikasi()
    {
        Console.WriteLine($"Laptop {merk} {tipe} menggunakan VGA {vga} dan Processor {processor}");
    }
}

class ASUS : Laptop
{
    public string merk;
    public ASUS(string tipe, string vga, string processor) : base("ASUS",tipe,vga, processor)
    {
    }
}

class ROG : ASUS
{
    public string tipe;
    public ROG(string vga, string processor) : base("ROG", vga, processor)
    {

    }
}

class Vivobook : ASUS
{
    public string tipe;
    public Vivobook(string vga, string processor) : base("Vivobook", vga, processor)
    {
    }

    public void Ngoding()
    {
        Console.WriteLine("Ctak Ctak Ctak, error lagi!!");
    }
}

class ACER : Laptop
{
    public ACER(string tipe, string vga, string processor) : base("ACER", tipe, vga, processor)
    {
    }
}

class Swift : ACER
{
    public string tipe;
    public Swift( string vga, string processor) : base("Swift", vga, processor)
    {
    }
}

class Predator : ACER
{
    public Predator(string vga, string processor) : base("Predator", vga, processor)
    {
    }

    public void BermainGame()
    {
        Console.WriteLine($"Laptop {merk} {tipe} sedang memainkan game");
    }
}

class Lenovo : Laptop
{
    public string tipe;
    public Lenovo(string tipe, string vga, string processor) : base("Lenovo", tipe, vga, processor)
    {
    }
}

class IdeaPad : Lenovo
{
    public string tipe;
    public IdeaPad(string vga, string processor) : base("IdeaPad", vga, processor)
    {
    }
}

class Legion : Lenovo
{
    public string tipe;
    public Legion(string vga, string processor) : base("Legion", vga, processor)
    {
    }
}

class program
{
    static void Main(string[] args)
    {
        Laptop laptop1 = new Vivobook("Nvidia", "Core i5");
        Laptop laptop2 = new IdeaPad("AMD", "Ryzen");
        Laptop predator = new Predator("AMD", "Core i7");


        ((Vivobook)laptop1).Ngoding();
        ((Vivobook)laptop1).spesifikasi();

        laptop2.LaptopDinyalakan();
        laptop2.LaptopDimatikan();


        ((Predator)predator).BermainGame();

        Laptop acer = new ACER("Predator", "AMD", "RYZEN");
        //((ACER)acer).BermainGame();
    }
}

