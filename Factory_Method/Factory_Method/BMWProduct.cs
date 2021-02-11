using System;
using System.Collections.Generic;
using System.Text;

namespace Factory_Method
{
    public class BMWProduct : IProduct
    {
        public string Operation()
        {
            return "{Result BMW}";
        }
    }
}
