using System;

namespace Factory_Method
{
    abstract class Car
    { }

    class ToyotaProduct : Car
    {
        public ToyotaProduct()
        {
            Console.Write("Toyota ");
            model();
            Engine_2_4();
        }

        void Engine_2_4()
        {
             Console.Write("2.4 \n");
        }

        void model()
        {
            Console.Write("Camry ");
        }
    }
}
