using System;
using System.Collections.Generic;
using System.Text;

namespace Factory_Method
{
    public class BMWCreator : CarCreator
    {
        public override IProduct FactoryMethod()
        {
            return new BMWProduct();
        }
    }
}
