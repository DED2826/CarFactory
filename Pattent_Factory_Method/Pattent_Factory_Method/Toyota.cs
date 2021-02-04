using System;
using System.Collections.Generic;
using System.Text;

namespace Pattent_Factory_Method
{
    class Toyota : FactoryInterface
    {
        public string getCarName()
        {
            return "Toyota ";
        }
        public string getCarModel()
        {
            return "Camry ";
        }
        public string getCarEngine()
        {
            return "2.4 ";
        }
        public string getCarEquipmet()
        {
            return "Lux \n";
        }
    }
}
