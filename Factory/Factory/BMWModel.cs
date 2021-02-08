using System;
using System.Collections.Generic;
using System.Text;

namespace Factory
{
    class BMWModel : ProductModelInterface
    {
        public string modelbuild()
        {
            return "{M5}";
        }
    }
}
