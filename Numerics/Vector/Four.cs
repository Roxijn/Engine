using System.Collections;
using System.ComponentModel;
using System.Runtime.InteropServices;

namespace Roxijn.Numerics;

public static partial class Vector
{
    [StructLayout(LayoutKind.Sequential)]
    public readonly struct Four : IEnumerable<float>
    {
        #region Fields
        public readonly float w, x, y, z;
        #endregion

        #region Constructors
        public Four(float s = 0) : this(s, s, s, s) { }

        public Four(float w, float x, float y, float z)
        {
            this.w = w;
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public Four(Two wx, Two yz) : this(wx.x, wx.y, yz.x, yz.y) { }
        public Four(Two wx, float y, float z) : this(wx.x, wx.y, y, z) { }
        public Four(float w, Two xy, float Z) : this(w, xy.x, xy.y, Z) { }
        public Four(float W, float X, Two yz) : this(W, X, yz.x, yz.y) { }
        public Four(Three wxy, float z) : this(wxy.x, wxy.y, wxy.z, z) { }
        public Four(float w, Three xyz) : this(w, xyz.x, xyz.y, xyz.z) { }
        #endregion

        #region IEnumerable
        public IEnumerator<float> GetEnumerator()
        {
            yield return w;
            yield return x;
            yield return y;
            yield return z;
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
        #endregion

        #region Operators
        public static Four operator +(Four v) => new Four(+v.w, +v.x, +v.y, +v.z);
        public static Four operator +(Four a, Four b) => new Four(a.w + b.w, a.x + b.x, a.y + b.y, a.z + b.z);

        public static Four operator -(Four v) => new Four(-v.w, -v.x, -v.y, -v.z);
        public static Four operator -(Four a, Four b) => new Four(a.w - b.w, a.x - b.x, a.y - b.y, a.z - b.z);

        public static Four operator *(Four a, Four b) => new Four(a.w * b.w, a.x * b.x, a.y * b.y, a.z * b.z);
        public static Four operator *(Four a, float b) => new Four(a.w * b, a.x * b, a.y * b, a.z * b);
        public static Four operator *(float a, Four b) => new Four(a * b.w, a * b.x, a * b.y, a * b.z);

        public static Four operator /(Four a, Four b) => new Four(a.w / b.w, a.x / b.x, a.y / b.y, a.z / b.z);
        public static Four operator /(Four a, float b) => new Four(a.w / b, a.x / b, a.y / b, a.z / b);
        public static Four operator /(float a, Four b) => new Four(a / b.w, a / b.x, a / b.y, a / b.z);

        public static Four operator %(Four a, Four b) => new Four(a.w % b.w, a.x % b.x, a.y % b.y, a.z % b.z);
        public static Four operator %(Four a, float b) => new Four(a.w % b, a.x % b, a.y % b, a.z % b);
        public static Four operator %(float a, Four b) => new Four(a % b.w, a % b.x, a % b.y, a % b.z);
        #endregion

        #region Swizzles
        [EditorBrowsable(EditorBrowsableState.Never)] public Two xx { get => new Two(x, x); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Two xy { get => new Two(x, y); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Two xz { get => new Two(x, z); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Two xw { get => new Two(x, w); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Two yx { get => new Two(y, x); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Two yy { get => new Two(y, y); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Two yz { get => new Two(y, z); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Two yw { get => new Two(y, w); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Two zx { get => new Two(z, x); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Two zy { get => new Two(z, y); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Two zz { get => new Two(z, z); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Two zw { get => new Two(z, w); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Two wx { get => new Two(w, x); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Two wy { get => new Two(w, y); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Two wz { get => new Two(w, z); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Two ww { get => new Two(w, w); }

        [EditorBrowsable(EditorBrowsableState.Never)] public Three xxx { get => new Three(x, x, x); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Three xxy { get => new Three(x, x, y); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Three xxz { get => new Three(x, x, z); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Three xxw { get => new Three(x, x, w); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Three xyx { get => new Three(x, y, x); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Three xyy { get => new Three(x, y, y); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Three xyz { get => new Three(x, y, z); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Three xyw { get => new Three(x, y, w); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Three xzx { get => new Three(x, z, x); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Three xzy { get => new Three(x, z, y); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Three xzz { get => new Three(x, z, z); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Three xzw { get => new Three(x, z, w); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Three xwx { get => new Three(x, w, x); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Three xwy { get => new Three(x, w, y); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Three xwz { get => new Three(x, w, z); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Three xww { get => new Three(x, w, w); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Three yxx { get => new Three(y, x, x); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Three yxy { get => new Three(y, x, y); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Three yxz { get => new Three(y, x, z); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Three yxw { get => new Three(y, x, w); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Three yyx { get => new Three(y, y, x); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Three yyy { get => new Three(y, y, y); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Three yyz { get => new Three(y, y, z); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Three yyw { get => new Three(y, y, w); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Three yzx { get => new Three(y, z, x); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Three yzy { get => new Three(y, z, y); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Three yzz { get => new Three(y, z, z); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Three yzw { get => new Three(y, z, w); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Three ywx { get => new Three(y, w, x); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Three ywy { get => new Three(y, w, y); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Three ywz { get => new Three(y, w, z); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Three yww { get => new Three(y, w, w); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Three zxx { get => new Three(z, x, x); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Three zxy { get => new Three(z, x, y); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Three zxz { get => new Three(z, x, z); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Three zxw { get => new Three(z, x, w); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Three zyx { get => new Three(z, y, x); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Three zyy { get => new Three(z, y, y); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Three zyz { get => new Three(z, y, z); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Three zyw { get => new Three(z, y, w); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Three zzx { get => new Three(z, z, x); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Three zzy { get => new Three(z, z, y); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Three zzz { get => new Three(z, z, z); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Three zzw { get => new Three(z, z, w); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Three zwx { get => new Three(z, w, x); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Three zwy { get => new Three(z, w, y); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Three zwz { get => new Three(z, w, z); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Three zww { get => new Three(z, w, w); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Three wxx { get => new Three(w, x, x); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Three wxy { get => new Three(w, x, y); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Three wxz { get => new Three(w, x, z); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Three wxw { get => new Three(w, x, w); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Three wyx { get => new Three(w, y, x); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Three wyy { get => new Three(w, y, y); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Three wyz { get => new Three(w, y, z); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Three wyw { get => new Three(w, y, w); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Three wzx { get => new Three(w, z, x); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Three wzy { get => new Three(w, z, y); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Three wzz { get => new Three(w, z, z); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Three wzw { get => new Three(w, z, w); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Three wwx { get => new Three(w, w, x); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Three wwy { get => new Three(w, w, y); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Three wwz { get => new Three(w, w, z); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Three www { get => new Three(w, w, w); }

        [EditorBrowsable(EditorBrowsableState.Never)] public Four xxxx { get => new Four(x, x, x, x); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four xxxy { get => new Four(x, x, x, y); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four xxxz { get => new Four(x, x, x, z); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four xxxw { get => new Four(x, x, x, w); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four xxyx { get => new Four(x, x, y, x); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four xxyy { get => new Four(x, x, y, y); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four xxyz { get => new Four(x, x, y, z); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four xxyw { get => new Four(x, x, y, w); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four xxzx { get => new Four(x, x, z, x); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four xxzy { get => new Four(x, x, z, y); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four xxzz { get => new Four(x, x, z, z); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four xxzw { get => new Four(x, x, z, w); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four xxwx { get => new Four(x, x, w, x); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four xxwy { get => new Four(x, x, w, y); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four xxwz { get => new Four(x, x, w, z); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four xxww { get => new Four(x, x, w, w); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four xyxx { get => new Four(x, y, x, x); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four xyxy { get => new Four(x, y, x, y); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four xyxz { get => new Four(x, y, x, z); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four xyxw { get => new Four(x, y, x, w); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four xyyx { get => new Four(x, y, y, x); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four xyyy { get => new Four(x, y, y, y); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four xyyz { get => new Four(x, y, y, z); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four xyyw { get => new Four(x, y, y, w); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four xyzx { get => new Four(x, y, z, x); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four xyzy { get => new Four(x, y, z, y); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four xyzz { get => new Four(x, y, z, z); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four xyzw { get => new Four(x, y, z, w); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four xywx { get => new Four(x, y, w, x); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four xywy { get => new Four(x, y, w, y); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four xywz { get => new Four(x, y, w, z); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four xyww { get => new Four(x, y, w, w); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four xzxx { get => new Four(x, z, x, x); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four xzxy { get => new Four(x, z, x, y); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four xzxz { get => new Four(x, z, x, z); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four xzxw { get => new Four(x, z, x, w); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four xzyx { get => new Four(x, z, y, x); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four xzyy { get => new Four(x, z, y, y); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four xzyz { get => new Four(x, z, y, z); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four xzyw { get => new Four(x, z, y, w); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four xzzx { get => new Four(x, z, z, x); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four xzzy { get => new Four(x, z, z, y); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four xzzz { get => new Four(x, z, z, z); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four xzzw { get => new Four(x, z, z, w); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four xzwx { get => new Four(x, z, w, x); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four xzwy { get => new Four(x, z, w, y); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four xzwz { get => new Four(x, z, w, z); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four xzww { get => new Four(x, z, w, w); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four xwxx { get => new Four(x, w, x, x); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four xwxy { get => new Four(x, w, x, y); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four xwxz { get => new Four(x, w, x, z); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four xwxw { get => new Four(x, w, x, w); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four xwyx { get => new Four(x, w, y, x); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four xwyy { get => new Four(x, w, y, y); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four xwyz { get => new Four(x, w, y, z); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four xwyw { get => new Four(x, w, y, w); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four xwzx { get => new Four(x, w, z, x); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four xwzy { get => new Four(x, w, z, y); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four xwzz { get => new Four(x, w, z, z); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four xwzw { get => new Four(x, w, z, w); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four xwwx { get => new Four(x, w, w, x); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four xwwy { get => new Four(x, w, w, y); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four xwwz { get => new Four(x, w, w, z); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four xwww { get => new Four(x, w, w, w); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four yxxx { get => new Four(y, x, x, x); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four yxxy { get => new Four(y, x, x, y); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four yxxz { get => new Four(y, x, x, z); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four yxxw { get => new Four(y, x, x, w); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four yxyx { get => new Four(y, x, y, x); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four yxyy { get => new Four(y, x, y, y); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four yxyz { get => new Four(y, x, y, z); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four yxyw { get => new Four(y, x, y, w); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four yxzx { get => new Four(y, x, z, x); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four yxzy { get => new Four(y, x, z, y); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four yxzz { get => new Four(y, x, z, z); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four yxzw { get => new Four(y, x, z, w); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four yxwx { get => new Four(y, x, w, x); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four yxwy { get => new Four(y, x, w, y); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four yxwz { get => new Four(y, x, w, z); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four yxww { get => new Four(y, x, w, w); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four yyxx { get => new Four(y, y, x, x); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four yyxy { get => new Four(y, y, x, y); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four yyxz { get => new Four(y, y, x, z); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four yyxw { get => new Four(y, y, x, w); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four yyyx { get => new Four(y, y, y, x); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four yyyy { get => new Four(y, y, y, y); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four yyyz { get => new Four(y, y, y, z); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four yyyw { get => new Four(y, y, y, w); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four yyzx { get => new Four(y, y, z, x); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four yyzy { get => new Four(y, y, z, y); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four yyzz { get => new Four(y, y, z, z); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four yyzw { get => new Four(y, y, z, w); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four yywx { get => new Four(y, y, w, x); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four yywy { get => new Four(y, y, w, y); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four yywz { get => new Four(y, y, w, z); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four yyww { get => new Four(y, y, w, w); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four yzxx { get => new Four(y, z, x, x); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four yzxy { get => new Four(y, z, x, y); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four yzxz { get => new Four(y, z, x, z); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four yzxw { get => new Four(y, z, x, w); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four yzyx { get => new Four(y, z, y, x); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four yzyy { get => new Four(y, z, y, y); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four yzyz { get => new Four(y, z, y, z); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four yzyw { get => new Four(y, z, y, w); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four yzzx { get => new Four(y, z, z, x); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four yzzy { get => new Four(y, z, z, y); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four yzzz { get => new Four(y, z, z, z); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four yzzw { get => new Four(y, z, z, w); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four yzwx { get => new Four(y, z, w, x); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four yzwy { get => new Four(y, z, w, y); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four yzwz { get => new Four(y, z, w, z); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four yzww { get => new Four(y, z, w, w); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four ywxx { get => new Four(y, w, x, x); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four ywxy { get => new Four(y, w, x, y); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four ywxz { get => new Four(y, w, x, z); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four ywxw { get => new Four(y, w, x, w); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four ywyx { get => new Four(y, w, y, x); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four ywyy { get => new Four(y, w, y, y); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four ywyz { get => new Four(y, w, y, z); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four ywyw { get => new Four(y, w, y, w); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four ywzx { get => new Four(y, w, z, x); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four ywzy { get => new Four(y, w, z, y); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four ywzz { get => new Four(y, w, z, z); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four ywzw { get => new Four(y, w, z, w); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four ywwx { get => new Four(y, w, w, x); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four ywwy { get => new Four(y, w, w, y); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four ywwz { get => new Four(y, w, w, z); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four ywww { get => new Four(y, w, w, w); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four zxxx { get => new Four(z, x, x, x); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four zxxy { get => new Four(z, x, x, y); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four zxxz { get => new Four(z, x, x, z); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four zxxw { get => new Four(z, x, x, w); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four zxyx { get => new Four(z, x, y, x); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four zxyy { get => new Four(z, x, y, y); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four zxyz { get => new Four(z, x, y, z); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four zxyw { get => new Four(z, x, y, w); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four zxzx { get => new Four(z, x, z, x); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four zxzy { get => new Four(z, x, z, y); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four zxzz { get => new Four(z, x, z, z); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four zxzw { get => new Four(z, x, z, w); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four zxwx { get => new Four(z, x, w, x); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four zxwy { get => new Four(z, x, w, y); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four zxwz { get => new Four(z, x, w, z); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four zxww { get => new Four(z, x, w, w); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four zyxx { get => new Four(z, y, x, x); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four zyxy { get => new Four(z, y, x, y); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four zyxz { get => new Four(z, y, x, z); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four zyxw { get => new Four(z, y, x, w); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four zyyx { get => new Four(z, y, y, x); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four zyyy { get => new Four(z, y, y, y); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four zyyz { get => new Four(z, y, y, z); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four zyyw { get => new Four(z, y, y, w); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four zyzx { get => new Four(z, y, z, x); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four zyzy { get => new Four(z, y, z, y); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four zyzz { get => new Four(z, y, z, z); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four zyzw { get => new Four(z, y, z, w); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four zywx { get => new Four(z, y, w, x); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four zywy { get => new Four(z, y, w, y); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four zywz { get => new Four(z, y, w, z); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four zyww { get => new Four(z, y, w, w); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four zzxx { get => new Four(z, z, x, x); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four zzxy { get => new Four(z, z, x, y); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four zzxz { get => new Four(z, z, x, z); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four zzxw { get => new Four(z, z, x, w); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four zzyx { get => new Four(z, z, y, x); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four zzyy { get => new Four(z, z, y, y); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four zzyz { get => new Four(z, z, y, z); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four zzyw { get => new Four(z, z, y, w); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four zzzx { get => new Four(z, z, z, x); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four zzzy { get => new Four(z, z, z, y); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four zzzz { get => new Four(z, z, z, z); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four zzzw { get => new Four(z, z, z, w); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four zzwx { get => new Four(z, z, w, x); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four zzwy { get => new Four(z, z, w, y); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four zzwz { get => new Four(z, z, w, z); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four zzww { get => new Four(z, z, w, w); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four zwxx { get => new Four(z, w, x, x); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four zwxy { get => new Four(z, w, x, y); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four zwxz { get => new Four(z, w, x, z); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four zwxw { get => new Four(z, w, x, w); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four zwyx { get => new Four(z, w, y, x); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four zwyy { get => new Four(z, w, y, y); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four zwyz { get => new Four(z, w, y, z); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four zwyw { get => new Four(z, w, y, w); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four zwzx { get => new Four(z, w, z, x); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four zwzy { get => new Four(z, w, z, y); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four zwzz { get => new Four(z, w, z, z); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four zwzw { get => new Four(z, w, z, w); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four zwwx { get => new Four(z, w, w, x); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four zwwy { get => new Four(z, w, w, y); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four zwwz { get => new Four(z, w, w, z); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four zwww { get => new Four(z, w, w, w); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four wxxx { get => new Four(w, x, x, x); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four wxxy { get => new Four(w, x, x, y); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four wxxz { get => new Four(w, x, x, z); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four wxxw { get => new Four(w, x, x, w); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four wxyx { get => new Four(w, x, y, x); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four wxyy { get => new Four(w, x, y, y); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four wxyz { get => new Four(w, x, y, z); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four wxyw { get => new Four(w, x, y, w); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four wxzx { get => new Four(w, x, z, x); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four wxzy { get => new Four(w, x, z, y); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four wxzz { get => new Four(w, x, z, z); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four wxzw { get => new Four(w, x, z, w); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four wxwx { get => new Four(w, x, w, x); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four wxwy { get => new Four(w, x, w, y); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four wxwz { get => new Four(w, x, w, z); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four wxww { get => new Four(w, x, w, w); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four wyxx { get => new Four(w, y, x, x); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four wyxy { get => new Four(w, y, x, y); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four wyxz { get => new Four(w, y, x, z); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four wyxw { get => new Four(w, y, x, w); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four wyyx { get => new Four(w, y, y, x); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four wyyy { get => new Four(w, y, y, y); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four wyyz { get => new Four(w, y, y, z); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four wyyw { get => new Four(w, y, y, w); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four wyzx { get => new Four(w, y, z, x); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four wyzy { get => new Four(w, y, z, y); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four wyzz { get => new Four(w, y, z, z); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four wyzw { get => new Four(w, y, z, w); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four wywx { get => new Four(w, y, w, x); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four wywy { get => new Four(w, y, w, y); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four wywz { get => new Four(w, y, w, z); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four wyww { get => new Four(w, y, w, w); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four wzxx { get => new Four(w, z, x, x); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four wzxy { get => new Four(w, z, x, y); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four wzxz { get => new Four(w, z, x, z); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four wzxw { get => new Four(w, z, x, w); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four wzyx { get => new Four(w, z, y, x); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four wzyy { get => new Four(w, z, y, y); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four wzyz { get => new Four(w, z, y, z); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four wzyw { get => new Four(w, z, y, w); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four wzzx { get => new Four(w, z, z, x); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four wzzy { get => new Four(w, z, z, y); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four wzzz { get => new Four(w, z, z, z); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four wzzw { get => new Four(w, z, z, w); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four wzwx { get => new Four(w, z, w, x); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four wzwy { get => new Four(w, z, w, y); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four wzwz { get => new Four(w, z, w, z); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four wzww { get => new Four(w, z, w, w); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four wwxx { get => new Four(w, w, x, x); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four wwxy { get => new Four(w, w, x, y); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four wwxz { get => new Four(w, w, x, z); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four wwxw { get => new Four(w, w, x, w); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four wwyx { get => new Four(w, w, y, x); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four wwyy { get => new Four(w, w, y, y); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four wwyz { get => new Four(w, w, y, z); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four wwyw { get => new Four(w, w, y, w); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four wwzx { get => new Four(w, w, z, x); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four wwzy { get => new Four(w, w, z, y); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four wwzz { get => new Four(w, w, z, z); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four wwzw { get => new Four(w, w, z, w); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four wwwx { get => new Four(w, w, w, x); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four wwwy { get => new Four(w, w, w, y); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four wwwz { get => new Four(w, w, w, z); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four wwww { get => new Four(w, w, w, w); }
        #endregion
    }
}
