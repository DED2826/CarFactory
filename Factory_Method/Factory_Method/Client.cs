using System;
using System.Collections.Generic;
using System.Text;

namespace Factory_Method
{
    public class Client
    {
        public void Main()
        {
            Console.WriteLine("App: Launched with the Toyota.");
            ClientCode(new ToyotaCreator());

            Console.WriteLine("");

            Console.WriteLine("App: Launched with the BMW.");
            ClientCode(new BMWCreator());
        }
        public void ClientCode(CarCreator creator)
        {
            Console.WriteLine("ClientClass: I'm not aware of the creator's class," +
                "but it still works.\n" + creator.CreateCar());
        }
    }
}
