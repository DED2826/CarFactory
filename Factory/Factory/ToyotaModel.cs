using System;
using System.Collections.Generic;
using System.Text;

namespace Factory
{
    class ToyotaModel : ProductModelInterface
    {
        public string modelbuild()
        {
            return "{Camry}";
        }
    }
}
