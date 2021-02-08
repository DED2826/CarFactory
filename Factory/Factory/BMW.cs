using System;
using System.Collections.Generic;
using System.Text;

namespace Factory
{
    class BMW : ProductInterface
    {
        public string marcbuild()
        {
            return "{BMW}";
        }
    }
}
