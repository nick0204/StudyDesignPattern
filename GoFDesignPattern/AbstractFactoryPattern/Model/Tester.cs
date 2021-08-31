using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern.Model
{
    class Tester
    {
        IMakeCamera[] factories = new IMakeCamera[2];
        public Tester()
        {
            factories[0] = new EvDayFactory();
            factories[1] = new HoDayFactory();
        }

        public void Test()
        {
            TestDirect();
            TestUsingFactory();
        }

        private void TestUsingFactory()
        {
            Camera camera = null;
            ITake lens = null;
            Console.WriteLine("AbstractFactory Pattern ==========");
            foreach (IMakeCamera imake in factories)
            {
                camera = imake.MakeCamera();
                lens = imake.MakeLens();
                TestCase(camera, lens);
            }
        }

        private void TestDirect()
        {
            Console.WriteLine("Directly use =========");
            Camera camera = new EvCamera();
            ITake lens = new HoLens();
            TestCase(camera, lens);
        }

        private void TestCase(Camera camera, ITake lens)
        {
            if(camera.PutInLens(lens) == false)
            {
                Console.WriteLine("Fail to put lens");
                return;
            }
            if(camera.TakePicture() == false)
            {
                Console.WriteLine("Fail to take picture");
                return;
            }
            Console.WriteLine("Test Success!!");
        }
    }
}
