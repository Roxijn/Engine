using System.Collections;
using System.ComponentModel;
using System.Runtime.InteropServices;

namespace Roxijn.Numerics;

public static partial class Vector
{
    [StructLayout(LayoutKind.Sequential)]
    public readonly struct Two : IEnumerable<float>
    {
        #region Fields
        public readonly float x, y;
        #endregion

        #region Constructors
        public Two() : this(0) { }

        public Two(float s) : this(s, s) { }

        public Two(float x, float y)
        {
            this.x = x; this.y = y;
        }
        #endregion

        #region IEnumerable
        public IEnumerator<float> GetEnumerator()
        {
            yield return x;
            yield return y;
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
        #endregion

        #region Operators
        public static Two operator +(Two v) => new Two(+v.x, +v.y);
        public static Two operator +(Two a, Two b) => new Two(a.x + b.x, a.y + b.y);

        public static Two operator -(Two v) => new Two(-v.x, -v.y);
        public static Two operator -(Two a, Two b) => new Two(a.x - b.x, a.y - b.y);

        public static Two operator *(Two a, Two b) => new Two(a.x * b.x, a.y * b.y);
        public static Two operator *(Two a, float b) => new Two(a.x * b, a.y * b);
        public static Two operator *(float a, Two b) => new Two(a * b.x, a * b.y);

        public static Two operator /(Two a, Two b) => new Two(a.x / b.x, a.y / b.y);
        public static Two operator /(Two a, float b) => new Two(a.x / b, a.y / b);
        public static Two operator /(float a, Two b) => new Two(a / b.x, a / b.y);

        public static Two operator %(Two a, Two b) => new Two(a.x % b.x, a.y % b.y);
        public static Two operator %(Two a, float b) => new Two(a.x % b, a.y % b);
        public static Two operator %(float a, Two b) => new Two(a % b.x, a % b.y);
        #endregion

        #region Swizzles
        [EditorBrowsable(EditorBrowsableState.Never)] public Two xx { get => new Two(x, x); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Two xy { get => new Two(x, y); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Two yx { get => new Two(y, x); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Two yy { get => new Two(y, y); }

        [EditorBrowsable(EditorBrowsableState.Never)] public Three xxx { get => new Three(x, x, x); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Three xxy { get => new Three(x, x, y); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Three xyx { get => new Three(x, y, x); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Three xyy { get => new Three(x, y, y); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Three yxx { get => new Three(y, x, x); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Three yxy { get => new Three(y, x, y); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Three yyx { get => new Three(y, y, x); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Three yyy { get => new Three(y, y, y); }

        [EditorBrowsable(EditorBrowsableState.Never)] public Four xxxx { get => new Four(x, x, x, x); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four xxxy { get => new Four(x, x, x, y); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four xxyx { get => new Four(x, x, y, x); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four xxyy { get => new Four(x, x, y, y); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four xyxx { get => new Four(x, y, x, x); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four xyxy { get => new Four(x, y, x, y); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four xyyx { get => new Four(x, y, y, x); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four xyyy { get => new Four(x, y, y, y); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four yxxx { get => new Four(y, x, x, x); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four yxxy { get => new Four(y, x, x, y); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four yxyx { get => new Four(y, x, y, x); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four yxyy { get => new Four(y, x, y, y); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four yyxx { get => new Four(y, y, x, x); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four yyxy { get => new Four(y, y, x, y); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four yyyx { get => new Four(y, y, y, x); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four yyyy { get => new Four(y, y, y, y); }
        #endregion
    }
}
