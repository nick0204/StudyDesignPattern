using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern.Model
{
    abstract class Camera
    {
        protected ITake Lens
        {
            get; set;
        }
        public virtual bool TakePicture()
        {
            if(Lens == null)
            {
                return false;
            }
            Lens.Take();
            return true;
        }
        public abstract bool PutInLens(ITake itake);
        public ITake GetOutLens()
        {
            ITake re = Lens;
            Lens = null;
            return re;
        }
        public Camera()
        {
            Lens = null;
        }
    }
}
