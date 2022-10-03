using System.Collections;
using System.Runtime.InteropServices;

namespace Roxijn.Numerics;

public static partial class Matrix
{
    [StructLayout(LayoutKind.Sequential)]
    public readonly struct Four : IEnumerable<float>
    {
        #region Fields
        public readonly float a, b, c, d,
                              e, f, g, h,
                              i, j, k, l,
                              m, n, o, p;
        #endregion

        #region Constructors
        public Four(float s = 1) : this(
            s, 0, 0, 0,
            0, s, 0, 0,
            0, 0, s, 0,
            0, 0, 0, s
        )
        { }

        public Four(
            float a, float b, float c, float d,
            float e, float f, float g, float h,
            float i, float j, float k, float l,
            float m, float n, float o, float p
        )
        {
            this.a = a; this.b = b; this.c = c; this.d = d;
            this.e = e; this.f = f; this.g = g; this.h = h;
            this.i = i; this.j = j; this.k = k; this.l = l;
            this.m = m; this.n = n; this.o = o; this.p = l;
        }

        public Four(Vector.Four r0, Vector.Four r1, Vector.Four r2, Vector.Four r3)
            : this(
                r0.w, r0.x, r0.y, r0.z,
                r1.w, r1.x, r1.y, r1.z,
                r2.w, r2.x, r2.y, r2.z,
                r3.w, r3.x, r3.y, r3.z
            )
        { }

        public Four(float s, Vector.Three r, Vector.Three c, Three m)
            : this(
                s, r.x, r.y, r.z,
                c.x, m.a, m.b, m.c,
                c.y, m.d, m.e, m.f,
                c.z, m.g, m.h, m.i
            )
        { }

        public Four(Three m, Vector.Three c, Vector.Three r, float s)
            : this(
                m.a, m.b, m.c, c.x,
                m.d, m.e, m.f, c.y,
                m.g, m.h, m.i, c.z,
                r.x, r.y, r.z, s
            )
        { }
        #endregion

        #region Properties
        public Vector.Four r0 { get => new Vector.Four(a, b, c, d); }
        public Vector.Four r1 { get => new Vector.Four(e, f, g, h); }
        public Vector.Four r2 { get => new Vector.Four(i, j, k, l); }
        public Vector.Four r3 { get => new Vector.Four(m, n, o, p); }

        public Vector.Four c0 { get => new Vector.Four(a, e, i, m); }
        public Vector.Four c1 { get => new Vector.Four(b, f, j, n); }
        public Vector.Four c2 { get => new Vector.Four(c, g, k, o); }
        public Vector.Four c3 { get => new Vector.Four(d, h, l, p); }
        #endregion

        #region IEnumerable
        public IEnumerator<float> GetEnumerator()
        {
            yield return a; yield return b; yield return c; yield return d;
            yield return e; yield return f; yield return g; yield return h;
            yield return i; yield return j; yield return k; yield return l;
            yield return m; yield return n; yield return o; yield return p;
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
        #endregion

        #region Operators
        public static Four operator *(Four a, Four b) => new Four(
            a.a * b.a + a.b * b.e + a.c * b.i + a.d * b.m,
            a.a * b.b + a.b * b.f + a.c * b.j + a.d * b.n,
            a.a * b.c + a.b * b.g + a.c * b.k + a.d * b.o,
            a.a * b.d + a.b * b.h + a.c * b.l + a.d * b.p,

            a.e * b.a + a.f * b.e + a.g * b.i + a.h * b.m,
            a.e * b.b + a.f * b.f + a.g * b.j + a.h * b.n,
            a.e * b.c + a.f * b.g + a.g * b.k + a.h * b.o,
            a.e * b.d + a.f * b.h + a.g * b.l + a.h * b.p,

            a.i * b.a + a.j * b.e + a.k * b.i + a.l * b.m,
            a.i * b.b + a.j * b.f + a.k * b.j + a.l * b.n,
            a.i * b.c + a.j * b.g + a.k * b.k + a.l * b.o,
            a.i * b.d + a.j * b.h + a.k * b.l + a.l * b.p,

            a.m * b.a + a.n * b.e + a.o * b.i + a.p * b.m,
            a.m * b.b + a.n * b.f + a.o * b.j + a.p * b.n,
            a.m * b.c + a.n * b.g + a.o * b.k + a.p * b.o,
            a.m * b.d + a.n * b.h + a.o * b.l + a.p * b.p
        );

        public static Vector.Four operator *(Four a, Vector.Four b) => new Vector.Four(
            a.a * b.w + a.b * b.x + a.c * b.y + a.d * b.z,
            a.e * b.w + a.f * b.x + a.g * b.y + a.h * b.z,
            a.i * b.w + a.j * b.x + a.k * b.y + a.l * b.z,
            a.m * b.w + a.n * b.x + a.o * b.y + a.p * b.z
        );

        public static Vector.Four operator *(Vector.Four a, Four b) => new Vector.Four(
            b.a * a.w + b.e * a.x + b.i * a.y + b.m * a.z,
            b.b * a.w + b.f * a.x + b.j * a.y + b.n * a.z,
            b.c * a.w + b.g * a.x + b.k * a.y + b.o * a.z,
            b.d * a.w + b.h * a.x + b.l * a.y + b.p * a.z
        );
        #endregion
    }
}