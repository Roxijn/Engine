using System.Collections;
using System.ComponentModel;
using System.Runtime.InteropServices;

namespace Roxijn.Numerics;

public static partial class Vector
{
    [StructLayout(LayoutKind.Sequential)]
    public readonly struct Three : IEnumerable<float>
    {
        #region Fields
        public readonly float x, y, z;
        #endregion

        #region Constructors
        public Three() : this(0) { }
        
        public Three(float s) : this(s, s, s) { }

        public Three(float x, float y, float z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public Three(Two xy, float z) : this(xy.x, xy.y, z) { }
        public Three(float x, Two yz) : this(x, yz.x, yz.y) { }
        #endregion

        #region IEnumerable
        public IEnumerator<float> GetEnumerator()
        {
            yield return x;
            yield return y;
            yield return z;
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
        #endregion

        #region Operators
        public static Three operator +(Three v) => new Three(+v.x, +v.y, +v.z);
        public static Three operator +(Three a, Three b) => new Three(a.x + b.x, a.y + b.y, a.z + b.z);

        public static Three operator -(Three v) => new Three(-v.x, -v.y, -v.z);
        public static Three operator -(Three a, Three b) => new Three(a.x - b.x, a.y - b.y, a.z - b.z);

        public static Three operator *(Three a, Three b) => new Three(a.x * b.x, a.y * b.y, a.z * b.z);
        public static Three operator *(Three a, float b) => new Three(a.x * b, a.y * b, a.z * b);
        public static Three operator *(float a, Three b) => new Three(a * b.x, a * b.y, a * b.z);

        public static Three operator /(Three a, Three b) => new Three(a.x / b.x, a.y / b.y, a.z / b.z);
        public static Three operator /(Three a, float b) => new Three(a.x / b, a.y / b, a.z / b);
        public static Three operator /(float a, Three b) => new Three(a / b.x, a / b.y, a / b.z);

        public static Three operator %(Three a, Three b) => new Three(a.x % b.x, a.y % b.y, a.z % b.z);
        public static Three operator %(Three a, float b) => new Three(a.x % b, a.y % b, a.z % b);
        public static Three operator %(float a, Three b) => new Three(a % b.x, a % b.y, a % b.z);
        #endregion

        #region Swizzles
        [EditorBrowsable(EditorBrowsableState.Never)] public Two xx { get => new Two(x, x); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Two xy { get => new Two(x, y); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Two xz { get => new Two(x, z); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Two yx { get => new Two(y, x); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Two yy { get => new Two(y, y); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Two yz { get => new Two(y, z); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Two zx { get => new Two(z, x); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Two zy { get => new Two(z, y); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Two zz { get => new Two(z, z); }

        [EditorBrowsable(EditorBrowsableState.Never)] public Three xxx { get => new Three(x, x, x); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Three xxy { get => new Three(x, x, y); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Three xxz { get => new Three(x, x, z); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Three xyx { get => new Three(x, y, x); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Three xyy { get => new Three(x, y, y); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Three xyz { get => new Three(x, y, z); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Three xzx { get => new Three(x, z, x); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Three xzy { get => new Three(x, z, y); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Three xzz { get => new Three(x, z, z); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Three yxx { get => new Three(y, x, x); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Three yxy { get => new Three(y, x, y); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Three yxz { get => new Three(y, x, z); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Three yyx { get => new Three(y, y, x); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Three yyy { get => new Three(y, y, y); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Three yyz { get => new Three(y, y, z); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Three yzx { get => new Three(y, z, x); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Three yzy { get => new Three(y, z, y); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Three yzz { get => new Three(y, z, z); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Three zxx { get => new Three(z, x, x); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Three zxy { get => new Three(z, x, y); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Three zxz { get => new Three(z, x, z); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Three zyx { get => new Three(z, y, x); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Three zyy { get => new Three(z, y, y); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Three zyz { get => new Three(z, y, z); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Three zzx { get => new Three(z, z, x); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Three zzy { get => new Three(z, z, y); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Three zzz { get => new Three(z, z, z); }

        [EditorBrowsable(EditorBrowsableState.Never)] public Four xxxx { get => new Four(x, x, x, x); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four xxxy { get => new Four(x, x, x, y); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four xxxz { get => new Four(x, x, x, z); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four xxyx { get => new Four(x, x, y, x); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four xxyy { get => new Four(x, x, y, y); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four xxyz { get => new Four(x, x, y, z); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four xxzx { get => new Four(x, x, z, x); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four xxzy { get => new Four(x, x, z, y); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four xxzz { get => new Four(x, x, z, z); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four xyxx { get => new Four(x, y, x, x); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four xyxy { get => new Four(x, y, x, y); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four xyxz { get => new Four(x, y, x, z); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four xyyx { get => new Four(x, y, y, x); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four xyyy { get => new Four(x, y, y, y); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four xyyz { get => new Four(x, y, y, z); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four xyzx { get => new Four(x, y, z, x); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four xyzy { get => new Four(x, y, z, y); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four xyzz { get => new Four(x, y, z, z); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four xzxx { get => new Four(x, z, x, x); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four xzxy { get => new Four(x, z, x, y); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four xzxz { get => new Four(x, z, x, z); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four xzyx { get => new Four(x, z, y, x); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four xzyy { get => new Four(x, z, y, y); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four xzyz { get => new Four(x, z, y, z); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four xzzx { get => new Four(x, z, z, x); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four xzzy { get => new Four(x, z, z, y); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four xzzz { get => new Four(x, z, z, z); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four yxxx { get => new Four(y, x, x, x); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four yxxy { get => new Four(y, x, x, y); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four yxxz { get => new Four(y, x, x, z); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four yxyx { get => new Four(y, x, y, x); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four yxyy { get => new Four(y, x, y, y); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four yxyz { get => new Four(y, x, y, z); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four yxzx { get => new Four(y, x, z, x); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four yxzy { get => new Four(y, x, z, y); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four yxzz { get => new Four(y, x, z, z); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four yyxx { get => new Four(y, y, x, x); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four yyxy { get => new Four(y, y, x, y); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four yyxz { get => new Four(y, y, x, z); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four yyyx { get => new Four(y, y, y, x); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four yyyy { get => new Four(y, y, y, y); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four yyyz { get => new Four(y, y, y, z); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four yyzx { get => new Four(y, y, z, x); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four yyzy { get => new Four(y, y, z, y); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four yyzz { get => new Four(y, y, z, z); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four yzxx { get => new Four(y, z, x, x); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four yzxy { get => new Four(y, z, x, y); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four yzxz { get => new Four(y, z, x, z); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four yzyx { get => new Four(y, z, y, x); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four yzyy { get => new Four(y, z, y, y); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four yzyz { get => new Four(y, z, y, z); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four yzzx { get => new Four(y, z, z, x); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four yzzy { get => new Four(y, z, z, y); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four yzzz { get => new Four(y, z, z, z); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four zxxx { get => new Four(z, x, x, x); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four zxxy { get => new Four(z, x, x, y); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four zxxz { get => new Four(z, x, x, z); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four zxyx { get => new Four(z, x, y, x); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four zxyy { get => new Four(z, x, y, y); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four zxyz { get => new Four(z, x, y, z); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four zxzx { get => new Four(z, x, z, x); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four zxzy { get => new Four(z, x, z, y); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four zxzz { get => new Four(z, x, z, z); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four zyxx { get => new Four(z, y, x, x); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four zyxy { get => new Four(z, y, x, y); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four zyxz { get => new Four(z, y, x, z); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four zyyx { get => new Four(z, y, y, x); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four zyyy { get => new Four(z, y, y, y); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four zyyz { get => new Four(z, y, y, z); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four zyzx { get => new Four(z, y, z, x); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four zyzy { get => new Four(z, y, z, y); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four zyzz { get => new Four(z, y, z, z); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four zzxx { get => new Four(z, z, x, x); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four zzxy { get => new Four(z, z, x, y); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four zzxz { get => new Four(z, z, x, z); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four zzyx { get => new Four(z, z, y, x); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four zzyy { get => new Four(z, z, y, y); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four zzyz { get => new Four(z, z, y, z); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four zzzx { get => new Four(z, z, z, x); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four zzzy { get => new Four(z, z, z, y); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four zzzz { get => new Four(z, z, z, z); }
        #endregion
    }
}
