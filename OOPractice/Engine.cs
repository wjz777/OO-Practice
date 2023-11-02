using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPractice
{
    public interface IEngine
    {
        public int Speed();
    }

    public class ElectricEngine : IEngine
    {
        public int Speed()
        {
            return 25;
        }
    }

    public class GasolineEngine : IEngine
    {
        public int Speed()
        {
            return 30;
        }
    }
}
