using System;
using System.Collections.Generic;
using System.Text;

namespace Factory_Method
{
    public class ToyotaCreator : CarCreator
    {
        public override IProduct FactoryMethod()
        {
            return new ToyotaProduct();
        }
    }
}
