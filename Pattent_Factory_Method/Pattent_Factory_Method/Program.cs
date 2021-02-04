using System;

namespace Pattent_Factory_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            Toyota toyota = new Toyota();
            Console.Write(toyota.getCarName());
            Console.Write(toyota.getCarModel());
            Console.Write(toyota.getCarEngine());
            Console.Write(toyota.getCarEquipmet());

            Mers mers = new Mers();
            Console.Write(mers.getCarName());
            Console.Write(mers.getCarModel());
            Console.Write(mers.getCarEngine());
            Console.Write(mers.getCarEquipmet());

            BMW bmw = new BMW();
            Console.Write(bmw.getCarName());
            Console.Write(bmw.getCarModel());
            Console.Write(bmw.getCarEngine());
            Console.Write(bmw.getCarEquipmet());

            Skoda skoda = new Skoda();
            Console.Write(skoda.getCarName());
            Console.Write(skoda.getCarModel());
            Console.Write(skoda.getCarEngine());
            Console.Write(skoda.getCarEquipmet());



            Console.ReadLine();
        }
    }
}
