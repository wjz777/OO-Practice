using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPractice
{
    public class Car
    {
        public string name;
        public int speed;

        public string SpeedUp()
        {
            speed += 10;
            return $"{name}:speed up {speed} km/h";
            //Console.WriteLine("Car: " + name);
            //Console.WriteLine("Speed: " + speed);
        }
    }
}
