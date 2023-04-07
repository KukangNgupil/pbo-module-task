//Muhammad Farrell Alfarro
//2050
//PBO A
using System;

namespace TugasKado
{
    public class Processor
    {
        public string? merk;
        public string? tipe;

    }
    public class Intel : Processor
    {
        public Intel(string merk, string tipe)
        {
            this.merk = merk;
            this.tipe = tipe;
            base.merk = "Intel";
        }
    }
    public class Amd : Processor
    {
        public Amd(string merk, string tipe)
        {
            this.merk = merk;
            this.tipe = tipe;
            base.merk = "AMD";
        }
    }
    public class CoreI3 : Intel
    {
        public CoreI3(string tipe) : base("Intel", tipe)
        {
            base.tipe = "CoreI3";
        }
    }
    public class CoreI5 : Intel
    {
        public CoreI5(string tipe) : base("Intel", tipe)
        {
            base.tipe = "CoreI5";
        }
    }
    public class CoreI7 : Intel
    {
        public CoreI7(string tipe) : base("Intel", tipe)
        {
            base.tipe = "CoreI7";
        }
    }
    public class Ryzen : Amd
    {
        public Ryzen(string tipe) : base("AMD", tipe)
        {
            base.tipe = "Ryzen";
        }
    }
    public class Athlon : Amd
    {
        public Athlon(string tipe) : base("AMD", tipe)
        {
            base.tipe = "Athlon";
        }
    }

    public class Vga
    {
        public string? merk;
    }
    public class Nvidia : Vga
    {
        public Nvidia()
        {
        }

        public Nvidia(string merk)
        {
            this.merk = merk;
            base.merk = "Nvidia";
        }
    }
    public class AMD : Vga
    {
        public AMD(string merk)
        {
            this.merk = merk;
            base.merk = "AMD";
        }
    }

    public class Laptop
    {
        public string? merk;
        public string? tipe;
        public Vga? vga;
        public Processor? processor;

        public void LaptopDinyalakan()
        {
            System.Console.WriteLine($"Laptop {merk} {tipe} menyala");
        }
        public void LaptopDimatikan()
        {
            System.Console.WriteLine($"Laptop {merk} {tipe} mati");
        }
    }
    public class Asus : Laptop
    {
        public Asus(string merk, string tipe)
        {
            this.merk = merk;
            base.merk = "ASUS";
        }
    }
    public class Acer : Laptop
    {
        public Acer(string merk, string tipe)
        {
            this.merk = merk;
            base.merk = "ACER";
        }
    }
    public class Lenovo : Laptop
    {
        public Lenovo(string merk, string tipe)
        {
            this.merk = merk;
            base.merk = "Lenovo";
        }
    }
    public class ROG : Asus
    {
        public ROG(string tipe, string v): base("ASUS", tipe)
        {
            base.tipe = "ROG";
        }
    }
    public class Vivobook : Asus
    {
        public Vivobook(string tipe, string v) : base("ASUS", tipe)
        {
            base.tipe = "Vivobook";
        }
        public void Ngoding()
        {
            System.Console.WriteLine("Ctak Ctak Ctak, error lagi!!");
        }
    }
    public class Swift : Acer
    {
        public Swift(string tipe, string v): base("ACER", tipe)
        {
            base.tipe = "Swift";
        }
    }
    public class Predator : Acer
    {
        public Predator(string tipe, string v): base("ACER", tipe)
        {
            base.tipe = "Predator";
        }
        public void BermainGame()
        {
            System.Console.WriteLine($"Laptop {merk} {tipe} sedang memainkan game");
        }
    }
    public class IdeaPad : Lenovo
    {
        public IdeaPad(string tipe, string v): base("Lenovo", tipe)
        {
            base.tipe = "IdeaPad";
        }
    }
    public class Legion : Lenovo
    {
        public Legion(string tipe, string v): base("Lenovo", tipe)
        {
            base.tipe = "Legion";
        }
    }
   internal class Program
    {
        static void Main(string[]args)
        {
            Vivobook laptop1 = new Vivobook("Nvidia", "CoreI5");
            IdeaPad laptop2 = new IdeaPad("AMD", "Ryzen");
            Predator predator = new Predator("AMD", "Corei7");
            //soal1
            laptop2.LaptopDinyalakan();
            laptop2.LaptopDimatikan();
            //soal2
            System.Console.WriteLine( );
            laptop1.Ngoding();
            //soal3
            //System.Console.WriteLine(laptop1.vga.merk);
            //soal4
            predator.BermainGame();
            System.Console.WriteLine();
            //soal5
            //Acer ACER = new Acer("Acer", "Predator");
            //ACER.BermainGame();

        }
    }
   

}
