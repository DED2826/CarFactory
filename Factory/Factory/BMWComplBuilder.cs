using System;
using System.Collections.Generic;
using System.Text;

namespace Factory
{
    class BMWComplBuilder : CarComplCreator1
    {
        public override ProductCompInterface FactoryComplMethod()
        {
            return new BMWCompl();
        }
    }
}
