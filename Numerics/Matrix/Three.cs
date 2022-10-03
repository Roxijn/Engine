using System.Collections;
using System.Runtime.InteropServices;

namespace Roxijn.Numerics;

public static partial class Matrix
{
    [StructLayout(LayoutKind.Sequential)]
    public readonly struct Three : IEnumerable<float>
    {
        #region Fields
        public readonly float a, b, c,
                              d, e, f,
                              g, h, i;
        #endregion 

        #region Constructors
        public Three(float S = 1) : this(
            S, 0, 0,
            0, S, 0,
            0, 0, S
        )
        { }

        public Three(
            float a, float b, float c,
            float d, float e, float f,
            float g, float h, float i
        )
        {
            this.a = a; this.b = b; this.c = c;
            this.d = d; this.e = e; this.f = f;
            this.g = g; this.h = h; this.i = i;
        }

        public Three(Vector.Three r0, Vector.Three r1, Vector.Three r2)
            : this(
                r0.x, r0.y, r0.z,
                r1.x, r1.y, r1.z,
                r2.x, r2.y, r2.z
            )
        { }

        public Three(Two m, Vector.Two c, Vector.Two r, float s)
            : this(
                m.a, m.b, c.x,
                m.c, m.d, c.y,
                r.x, r.y, s
            )
        { }

        public Three(float s, Vector.Two c, Vector.Two r, Two m)
            : this(
                s, r.x, r.y,
                c.x, m.a, m.b,
                c.y, m.c, m.d
            )
        { }
        #endregion

        #region Properties
        public Vector.Three r0 { get => new Vector.Three(a, b, c); }
        public Vector.Three r1 { get => new Vector.Three(d, e, f); }
        public Vector.Three r3 { get => new Vector.Three(g, h, i); }

        public Vector.Three c0 { get => new Vector.Three(a, d, g); }
        public Vector.Three c1 { get => new Vector.Three(b, e, h); }
        public Vector.Three c2 { get => new Vector.Three(c, f, i); }
        #endregion

        #region IEnumerable
        public IEnumerator<float> GetEnumerator()
        {
            yield return a; yield return b; yield return c;
            yield return d; yield return e; yield return f;
            yield return g; yield return h; yield return i;
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
        #endregion

        #region Operators
        public static Three operator *(Three a, Three b) => new Three(
            a.a * b.a + a.b * b.d + a.c * b.g,
            a.a * b.b + a.b * b.e + a.c * b.h,
            a.a * b.c + a.b * b.f + a.c * b.i,

            a.d * b.a + a.e * b.d + a.f * b.g,
            a.d * b.b + a.e * b.e + a.f * b.h,
            a.d * b.c + a.e * b.f + a.f * b.i,

            a.g * b.a + a.h * b.d + a.i * b.g,
            a.g * b.b + a.h * b.e + a.i * b.h,
            a.g * b.c + a.h * b.f + a.i * b.i
        );

        public static Vector.Three operator *(Three a, Vector.Three b) => new Vector.Three(
            a.a * b.x + a.b * b.y + a.c * b.z,
            a.d * b.x + a.e * b.y + a.f * b.z,
            a.g * b.x + a.h * b.y + a.i * b.z
        );

        public static Vector.Three operator *(Vector.Three a, Three b) => new Vector.Three(
            b.a * a.x + b.d * a.y + b.g * a.z,
            b.b * a.x + b.e * a.y + b.h * a.z,
            b.c * a.x + b.f * a.y + b.i * a.z
        );

        public static Three operator *(float a, Three b) => new Three(
            a * b.a, a * b.b, a * b.c,
            a * b.d, a * b.e, a * b.f,
            a * b.g, a * b.h, a * b.i
        );

        public static Three operator *(Three a, float b) => new Three(
            b * a.a, b * a.b, b * a.c,
            b * a.d, b * a.e, b * a.f,
            b * a.g, b * a.h, b * a.i
        );
        #endregion
    }
}