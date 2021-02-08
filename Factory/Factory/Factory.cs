using System;
using System.Collections.Generic;
using System.Text;

namespace Factory
{
    class Factory 
    {
        public void Main()
        {
            Console.Write("Marka ");
            CarCode(new ToyotaBilder());

            Console.Write("Model ");
            CarCode1(new ToyotaModelBuilder());

            Console.Write("Compl ");
            CarCode2(new ToyotaComlBuilder());

            Console.WriteLine("Toyota Camry Lux ");

            Console.WriteLine();

            Console.Write("Marka ");
            CarCodeBMW(new BMWBuilder());

            Console.Write("Marka ");
            CarCodeBMW1(new BMWModelBuilder());

            Console.Write("Marka ");
            CarCodeBMW2(new BMWComplBuilder());

            Console.WriteLine("BMW M5 Competishion ");

            Console.WriteLine();
        }

        public void CarCode(CarCreator creator)
        {
            Console.WriteLine(creator.BuildingOperation());
        }

        public void CarCode1(CarModelCreator creator)
        {
            Console.WriteLine(creator.BuildingOperation1());
        }

        public void CarCode2(CarComplCreator creator)
        {
            Console.WriteLine(creator.BuildingOperation2());
        }

        public void CarCodeBMW(CarCreator1 creator)
        {
            Console.WriteLine(creator.BuildingOperationBMW());
        }

        public void CarCodeBMW1(CarModelCreator1 creator)
        {
            Console.WriteLine(creator.BuildingOperationBMW1());
        }

        public void CarCodeBMW2(CarComplCreator1 creator)
        {
            Console.WriteLine(creator.BuildingOperationBMW2());
        }
    }
}
