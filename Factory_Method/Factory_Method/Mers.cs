namespace Factory_Method
{
    class Mers : CarCreator
    {
        public override Car Create()
        {
            return new MersProduct();
        }
    }
}