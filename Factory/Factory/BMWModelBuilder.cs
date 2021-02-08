using System;
using System.Collections.Generic;
using System.Text;

namespace Factory
{
    class BMWModelBuilder : CarModelCreator1
    {
        public override ProductModelInterface FactoryModelMethod()
        {
            return new BMWModel();
        }
    }
}
