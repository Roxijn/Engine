using System.Collections;
using System.Runtime.InteropServices;

namespace Roxijn.Numerics;

public static partial class Matrix
{
    [StructLayout(LayoutKind.Sequential)]
    public readonly struct Two : IEnumerable<float>
    {
        #region Fields
        public readonly float a, b,
                              c, d;
        #endregion

        #region Constructors
        public Two(float S = 1) : this(
            S, 0,
            0, S
        )
        { }

        public Two(
            float A = 1, float B = 0,
            float C = 0, float D = 1
        )
        {
            this.a = A; this.b = B;
            this.c = C; this.d = D;
        }

        public Two(Vector.Two r0, Vector.Two r1)
            : this(
                r0.x, r0.y,
                r1.x, r1.y
            )
        { }
        #endregion

        #region Properties
        public Vector.Two r0 { get => new Vector.Two(a, b); }
        public Vector.Two r1 { get => new Vector.Two(c, d); }

        public Vector.Two c0 { get => new Vector.Two(a, c); }
        public Vector.Two c1 { get => new Vector.Two(b, d); }
        #endregion

        #region IEnumerable
        public IEnumerator<float> GetEnumerator()
        {
            yield return a; yield return b;
            yield return c; yield return d;
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
        #endregion

        #region Operators
        public static Two operator *(Two a, Two b) => new Two(
            a.a * b.a + a.b * b.c,
            a.a * b.b + a.b * b.d,

            a.c * b.a + a.d * b.c,
            a.c * b.b + a.d * b.d
        );

        public static Vector.Two operator *(Two a, Vector.Two b) => new Vector.Two(
            a.a * b.x + a.b * b.y,
            a.c * b.x + a.d * b.y
        );

        public static Vector.Two operator *(Vector.Two a, Two b) => new Vector.Two(
            b.a * a.x + b.c * a.y,
            b.b * a.x + b.d * a.y
        );

        public static Two operator *(float a, Two b) => new Two(
            a * b.a, a * b.b,
            a * b.c, a * b.d
        );

        public static Two operator *(Two a, float b) => new Two(
            a.a * b, a.b * b,
            a.c * b, a.d * b
        );

        #endregion
    }
}