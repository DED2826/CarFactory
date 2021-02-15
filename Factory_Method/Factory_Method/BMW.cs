﻿namespace Factory_Method
{
    class BMW : CarCreator
    {
        public override Car Create()
        {
            return new BMWProduct();
        }
    }
}
