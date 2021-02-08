using System;
using System.Collections.Generic;
using System.Text;

namespace Factory
{
    class ToyotaCompl : ProductCompInterface
    {
        public string complbuild()
        {
            return "{Lux}";
        }
    }
}
