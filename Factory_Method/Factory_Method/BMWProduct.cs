using System;

namespace Factory_Method
{
    class BMWProduct : Car
    {
        public BMWProduct()
        {
            Console.Write("BMW ");
            model();
            Engine();
        }

        public void Engine()
        {
            Console.Write("2.8 Biturbo \n");
        }

        public void model()
        {
            Console.Write("M4 ");
        }
    }
}
