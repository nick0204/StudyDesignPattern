using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern.Model
{
    class EvLens : ITake
    {
        public void Take()
        {
            Console.WriteLine("Softly take photo.");
        }
        public void AutoFocus()
        {
            Console.WriteLine("Auto focus Control feature.");
        }
    }
}
