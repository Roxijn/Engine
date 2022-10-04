using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roxijn.Numerics;

public readonly struct Quaternion
{
    #region Fields
    public readonly float r, i, j, k;
    #endregion

    #region Constructors
    public Quaternion() : this(0, 0, 0, 0) { }

    public Quaternion(float r, float i, float j, float k)
    {
        this.r = r; this.i = i; this.j = j; this.k = k;
    }
    #endregion

    #region Operators
    public static Quaternion operator *(Quaternion a, Quaternion b) => new Quaternion
    (
        a.r * b.r - a.i * b.i - a.j * b.j - a.k * b.k,
        a.r * b.i + a.i * b.r + a.j * b.k - a.k * b.j,
        a.r * b.j + a.j * b.r + a.k * b.i - a.i * b.k,
        a.r * b.k + a.k * b.r + a.i * b.j - a.j * b.i
    );

    public static Quaternion operator *(Quaternion a, float b) => new Quaternion
    (
        a.r * b, a.i * b, a.j * b, a.k * b
    );

    public static Quaternion operator +(Quaternion a, Quaternion b) => new Quaternion
    (
        a.r + b.r, a.i + b.i, a.j + b.j, a.k + b.k
    );
    #endregion
}
