using System.ComponentModel;

namespace Roxijn.Numerics;

public static partial class Vector
{
    public readonly struct Three
    {
        #region Constructors
        public Three(Single X = 0, Single Y = 0, Single Z = 0)
        {
            this.X = X; this.Y = Y; this.Z = Z;
        }

        public Three(Two V, Single Z) : this(V.X, V.Y, Z) { }
        public Three(Single X, Two V) : this(X, V.X, V.Y) { }
        #endregion

        #region Properties
        public Single X { get; init; }
        public Single Y { get; init; }
        public Single Z { get; init; }
        #endregion

        #region Operators
        public static Three operator +(Three v) => new Three(+v.X, +v.Y, +v.Z);
        public static Three operator +(Three a, Three b) => new Three(a.X + b.X, a.Y + b.Y, a.Z + b.Z);

        public static Three operator -(Three v) => new Three(-v.X, -v.Y, -v.Z);
        public static Three operator -(Three a, Three b) => new Three(a.X - b.X, a.Y - b.Y, a.Z - b.Z);

        public static Three operator *(Three a, Three b) => new Three(a.X * b.X, a.Y * b.Y, a.Z * b.Z);
        public static Three operator *(Three a, Single b) => new Three(a.X * b, a.Y * b, a.Z * b);
        public static Three operator *(Single a, Three b) => new Three(a * b.X, a * b.Y, a * b.Z);

        public static Three operator /(Three a, Three b) => new Three(a.X / b.X, a.Y / b.Y, a.Z / b.Z);
        public static Three operator /(Three a, Single b) => new Three(a.X / b, a.Y / b, a.Z / b);
        public static Three operator /(Single a, Three b) => new Three(a / b.X, a / b.Y, a / b.Z);

        public static Three operator %(Three a, Three b) => new Three(a.X % b.X, a.Y % b.Y, a.Z % b.Z);
        public static Three operator %(Three a, Single b) => new Three(a.X % b, a.Y % b, a.Z % b);
        public static Three operator %(Single a, Three b) => new Three(a % b.X, a % b.Y, a % b.Z);
        #endregion

        #region Swizzles
        [EditorBrowsable(EditorBrowsableState.Never)] public Two XX { get => new Two(X, X); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Two XY { get => new Two(X, Y); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Two XZ { get => new Two(X, Z); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Two YX { get => new Two(Y, X); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Two YY { get => new Two(Y, Y); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Two YZ { get => new Two(Y, Z); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Two ZX { get => new Two(Z, X); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Two ZY { get => new Two(Z, Y); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Two ZZ { get => new Two(Z, Z); }

        [EditorBrowsable(EditorBrowsableState.Never)] public Three XXX { get => new Three(X, X, X); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Three XXY { get => new Three(X, X, Y); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Three XXZ { get => new Three(X, X, Z); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Three XYX { get => new Three(X, Y, X); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Three XYY { get => new Three(X, Y, Y); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Three XYZ { get => new Three(X, Y, Z); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Three XZX { get => new Three(X, Z, X); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Three XZY { get => new Three(X, Z, Y); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Three XZZ { get => new Three(X, Z, Z); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Three YXX { get => new Three(Y, X, X); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Three YXY { get => new Three(Y, X, Y); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Three YXZ { get => new Three(Y, X, Z); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Three YYX { get => new Three(Y, Y, X); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Three YYY { get => new Three(Y, Y, Y); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Three YYZ { get => new Three(Y, Y, Z); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Three YZX { get => new Three(Y, Z, X); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Three YZY { get => new Three(Y, Z, Y); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Three YZZ { get => new Three(Y, Z, Z); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Three ZXX { get => new Three(Z, X, X); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Three ZXY { get => new Three(Z, X, Y); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Three ZXZ { get => new Three(Z, X, Z); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Three ZYX { get => new Three(Z, Y, X); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Three ZYY { get => new Three(Z, Y, Y); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Three ZYZ { get => new Three(Z, Y, Z); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Three ZZX { get => new Three(Z, Z, X); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Three ZZY { get => new Three(Z, Z, Y); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Three ZZZ { get => new Three(Z, Z, Z); }

        [EditorBrowsable(EditorBrowsableState.Never)] public Four XXXX { get => new Four(X, X, X, X); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four XXXY { get => new Four(X, X, X, Y); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four XXXZ { get => new Four(X, X, X, Z); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four XXYX { get => new Four(X, X, Y, X); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four XXYY { get => new Four(X, X, Y, Y); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four XXYZ { get => new Four(X, X, Y, Z); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four XXZX { get => new Four(X, X, Z, X); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four XXZY { get => new Four(X, X, Z, Y); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four XXZZ { get => new Four(X, X, Z, Z); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four XYXX { get => new Four(X, Y, X, X); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four XYXY { get => new Four(X, Y, X, Y); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four XYXZ { get => new Four(X, Y, X, Z); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four XYYX { get => new Four(X, Y, Y, X); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four XYYY { get => new Four(X, Y, Y, Y); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four XYYZ { get => new Four(X, Y, Y, Z); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four XYZX { get => new Four(X, Y, Z, X); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four XYZY { get => new Four(X, Y, Z, Y); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four XYZZ { get => new Four(X, Y, Z, Z); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four XZXX { get => new Four(X, Z, X, X); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four XZXY { get => new Four(X, Z, X, Y); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four XZXZ { get => new Four(X, Z, X, Z); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four XZYX { get => new Four(X, Z, Y, X); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four XZYY { get => new Four(X, Z, Y, Y); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four XZYZ { get => new Four(X, Z, Y, Z); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four XZZX { get => new Four(X, Z, Z, X); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four XZZY { get => new Four(X, Z, Z, Y); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four XZZZ { get => new Four(X, Z, Z, Z); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four YXXX { get => new Four(Y, X, X, X); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four YXXY { get => new Four(Y, X, X, Y); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four YXXZ { get => new Four(Y, X, X, Z); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four YXYX { get => new Four(Y, X, Y, X); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four YXYY { get => new Four(Y, X, Y, Y); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four YXYZ { get => new Four(Y, X, Y, Z); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four YXZX { get => new Four(Y, X, Z, X); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four YXZY { get => new Four(Y, X, Z, Y); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four YXZZ { get => new Four(Y, X, Z, Z); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four YYXX { get => new Four(Y, Y, X, X); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four YYXY { get => new Four(Y, Y, X, Y); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four YYXZ { get => new Four(Y, Y, X, Z); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four YYYX { get => new Four(Y, Y, Y, X); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four YYYY { get => new Four(Y, Y, Y, Y); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four YYYZ { get => new Four(Y, Y, Y, Z); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four YYZX { get => new Four(Y, Y, Z, X); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four YYZY { get => new Four(Y, Y, Z, Y); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four YYZZ { get => new Four(Y, Y, Z, Z); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four YZXX { get => new Four(Y, Z, X, X); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four YZXY { get => new Four(Y, Z, X, Y); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four YZXZ { get => new Four(Y, Z, X, Z); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four YZYX { get => new Four(Y, Z, Y, X); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four YZYY { get => new Four(Y, Z, Y, Y); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four YZYZ { get => new Four(Y, Z, Y, Z); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four YZZX { get => new Four(Y, Z, Z, X); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four YZZY { get => new Four(Y, Z, Z, Y); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four YZZZ { get => new Four(Y, Z, Z, Z); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four ZXXX { get => new Four(Z, X, X, X); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four ZXXY { get => new Four(Z, X, X, Y); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four ZXXZ { get => new Four(Z, X, X, Z); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four ZXYX { get => new Four(Z, X, Y, X); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four ZXYY { get => new Four(Z, X, Y, Y); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four ZXYZ { get => new Four(Z, X, Y, Z); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four ZXZX { get => new Four(Z, X, Z, X); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four ZXZY { get => new Four(Z, X, Z, Y); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four ZXZZ { get => new Four(Z, X, Z, Z); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four ZYXX { get => new Four(Z, Y, X, X); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four ZYXY { get => new Four(Z, Y, X, Y); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four ZYXZ { get => new Four(Z, Y, X, Z); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four ZYYX { get => new Four(Z, Y, Y, X); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four ZYYY { get => new Four(Z, Y, Y, Y); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four ZYYZ { get => new Four(Z, Y, Y, Z); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four ZYZX { get => new Four(Z, Y, Z, X); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four ZYZY { get => new Four(Z, Y, Z, Y); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four ZYZZ { get => new Four(Z, Y, Z, Z); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four ZZXX { get => new Four(Z, Z, X, X); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four ZZXY { get => new Four(Z, Z, X, Y); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four ZZXZ { get => new Four(Z, Z, X, Z); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four ZZYX { get => new Four(Z, Z, Y, X); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four ZZYY { get => new Four(Z, Z, Y, Y); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four ZZYZ { get => new Four(Z, Z, Y, Z); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four ZZZX { get => new Four(Z, Z, Z, X); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four ZZZY { get => new Four(Z, Z, Z, Y); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four ZZZZ { get => new Four(Z, Z, Z, Z); }
        #endregion
    }

    public static Single Dot(this Three a, Three b) => a.X * b.X + a.Y * b.Y + a.Z * b.Z;
    public static Three Cross(this Three a, Three b) => new Three(
        a.Y * b.Z - a.Z * b.Y,
        a.Z * b.X - a.X * b.Z,
        a.X * b.Y - a.Y * b.X
    );
}
