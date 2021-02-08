using System;
using System.Collections.Generic;
using System.Text;

namespace Factory
{
    abstract class CarModelCreator
    {
        public abstract ProductModelInterface FactoryModelMethod();

        public string BuildingOperation1()
        {
            var product = FactoryModelMethod();
            var result = "Result: Camry "
                + product.modelbuild();

            return result;
        }

    }

    abstract class CarModelCreator1
    {
        public abstract ProductModelInterface FactoryModelMethod();

        public string BuildingOperationBMW1()
        {
            var product = FactoryModelMethod();
            var result = "Result: M5 "
                + product.modelbuild();

            return result;
        }

    }
}
