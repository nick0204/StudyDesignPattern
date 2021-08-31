using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern.Model
{
    class HoLens : ITake
    {
        public void Take()
        {
            Console.WriteLine("Natural.");
        }
        public void ManualFocus()
        {
            Console.WriteLine("Manually control focus by user.");
        }
    }
}
