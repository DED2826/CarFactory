using System;
using System.Collections.Generic;
using System.Text;

namespace Factory_Method
{
    public class ToyotaProduct : IProduct
    {
        public string Operation()
        {
            return "{Result Toyota}";
        }
    }
}
