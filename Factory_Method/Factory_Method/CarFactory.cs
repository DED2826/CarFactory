using System;
using System.Collections.Generic;
using System.Text;

namespace Factory_Method
{
    public abstract class CarCreator
    {
        public abstract IProduct FactoryMethod();
        public string CreateCar()
        {
            var product = FactoryMethod();
            var result = "CarCreator: The same creator's code has just worked with "
                + product.Operation();

            return result;
        }
    }
}
