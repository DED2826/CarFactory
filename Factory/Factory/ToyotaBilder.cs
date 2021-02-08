using System;
using System.Collections.Generic;
using System.Text;

namespace Factory
{
    class ToyotaBilder : CarCreator
    {
        public override ProductInterface FactoryMethod()
        {
            return new Toyota();
        }
    }
}
