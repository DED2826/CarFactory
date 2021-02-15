using System;

namespace Factory_Method
{
    class MersProduct : Car
    {
        public MersProduct()
        {
            Console.Write("Mercedes-benz ");
            model();
            Engine();
        }

        void Engine()
        {
            Console.Write("6.3 \n");
        }

        void model()
        {
            Console.Write("E ");
        }
    }
}