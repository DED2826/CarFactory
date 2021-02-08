using System;
using System.Collections.Generic;
using System.Text;

namespace Factory
{
    class ToyotaModelBuilder : CarModelCreator
    {
        public override ProductModelInterface FactoryModelMethod()
        {
            return new ToyotaModel();
        }
    }
}
