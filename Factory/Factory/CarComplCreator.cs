using System;
using System.Collections.Generic;
using System.Text;

namespace Factory
{
    abstract class CarComplCreator
    {
        public abstract ProductCompInterface FactoryComplMethod();

        public string BuildingOperation2()
        {
            var product = FactoryComplMethod();
            var result = "Result: Lux "
                + product.complbuild();

            return result;
        }
    }

    abstract class CarComplCreator1
    {
        public abstract ProductCompInterface FactoryComplMethod();

        public string BuildingOperationBMW2()
        {
            var product = FactoryComplMethod();
            var result = "Result: Competishion "
                + product.complbuild();

            return result;
        }
    }
}
