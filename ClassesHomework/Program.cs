using System;

namespace ClassesHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            Smartphone tel1 = new Smartphone("Iphone","13 Pro Max","Black",128,8);
            /*tel.brend = "Iphone";
            tel.name = "13 Pro Max";
            tel.colour = "black";
            tel.memory = 128;
            tel.ram = 8;*/

            Smartphone tel2 = new Smartphone("Samsung", "Galaxy Note10+", "Thunder Blue", 256, 12);

            Console.WriteLine(tel1.Mobile());
            Console.WriteLine(tel2.Mobile());

            Laptop pc1 = new Laptop("Asus", "VivaBook", "White", "Intel i7", "ssd", 256, 8);
            Laptop pc2 = new Laptop("HP", "250 G7", "Gray", "Intel i3", "hdd", 512, 8);
            Console.WriteLine(pc1.Pc());
            Console.WriteLine(pc2.Pc());
        }
    }
}
