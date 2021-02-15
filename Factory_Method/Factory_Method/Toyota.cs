namespace Factory_Method
{
    class ToyotaCreator : CarCreator
    { 
        public override Car Create()
        {
            return new ToyotaProduct();
        }
    }
}
