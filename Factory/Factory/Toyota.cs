using System;
using System.Collections.Generic;
using System.Text;

namespace Factory
{
    class Toyota : ProductInterface
    {
        public string marcbuild()
        {
            return "{Toyota}";
        }
    }
}
