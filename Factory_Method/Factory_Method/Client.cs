using System;

namespace Factory_Method
{
    public class Client
    {
        public void Main()
        {
            CarCreator _car = new ToyotaCreator();
            Car toyota = _car.Create();

            _car = new BMW();
            Car bmw = _car.Create();

            _car = new Mers();
            Car mers = _car.Create();

            Console.ReadLine();
        }
    }
}
