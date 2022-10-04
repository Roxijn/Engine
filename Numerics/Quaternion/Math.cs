using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roxijn.Numerics
{
    public static partial class Math
    {
        public static Quaternion Conjugate(this Quaternion a) => new Quaternion(a.r, -a.i, -a.j, -a.k);

        public static Quaternion Unit(this Quaternion a)
        {
            var n = Sqrt(a.i * a.i + a.j * a.j + a.k * a.k + a.r * a.r);
            return new Quaternion(a.r / n, a.i / n, a.j / n, a.k / n);
        }
    }
}
