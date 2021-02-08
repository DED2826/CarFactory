using System;
using System.Collections.Generic;
using System.Text;

namespace Factory
{
    abstract class CarCreator
    {
        public abstract ProductInterface FactoryMethod();

        public string BuildingOperation()
        {
            var product = FactoryMethod();
            var result = "Result: Toyota  "
                + product.marcbuild();

            return result;
        }
    }

    abstract class CarCreator1
    {
        public abstract ProductInterface FactoryMethod();

        public string BuildingOperationBMW()
        {
            var product = FactoryMethod();
            var result = "Result: BMW  "
                + product.marcbuild();

            return result;
        }
    }
}
