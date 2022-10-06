using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roxijn.Core.Base
{
    public abstract class Pipeline<T>
    {
        public abstract void Step(T frame);
    }
}
