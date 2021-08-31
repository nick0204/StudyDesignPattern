using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern.Model
{
    class HoDayFactory : IMakeCamera
    {
        public Camera MakeCamera()
        {
            return new HoCamera();
        }

        public ITake MakeLens()
        {
            return new HoLens();
        }
    }
}
