using System;
using System.Collections.Generic;
using System.Text;

namespace Factory
{
    class BMWBuilder : CarCreator1
    {
        public override ProductInterface FactoryMethod()
        {
            return new BMW();
        }
    }
}
