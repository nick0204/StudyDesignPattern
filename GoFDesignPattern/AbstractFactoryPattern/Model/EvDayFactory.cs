using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern.Model
{
    class EvDayFactory : IMakeCamera
    {
        public Camera MakeCamera()
        {
            return new EvCamera();
        }

        public ITake MakeLens()
        {
            return new EvLens();
        }
    }
}
