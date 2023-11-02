using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPractice
{
    public class Car : Vehicle
    {
        public Car()
        {
        }

        public Car(string name, int speed) : base(name, speed)
        {
        }

        public Car(IEngine engine) : base("Car", engine.Speed())
        {
        }
    }
}
