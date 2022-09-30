using System.ComponentModel;

namespace Roxijn.Numerics;

public static partial class Vector
{
    public readonly struct Four
    {
        #region Constructors
        public Four(Single W = 0, Single X = 0, Single Y = 0, Single Z = 0)
        {
            this.W = W; this.X = X; this.Y = Y; this.Z = Z;
        }

        public Four(Two V1, Two V2) : this(V1.X, V1.Y, V2.X, V2.Y) { }
        public Four(Two V, Single Y, Single Z) : this(V.X, V.Y, Y, Z) { }
        public Four(Single W, Two V, Single Z) : this(W, V.X, V.Y, Z) { }
        public Four(Single W, Single X, Two V) : this(W, X, V.X, V.Y) { }
        public Four(Three V, Single Z) : this(V.X, V.Y, V.Z, Z) { }
        public Four(Single W, Three V) : this(W, V.X, V.Y, V.Z) { }
        #endregion

        #region Properties
        public Single W { get; init; }
        public Single X { get; init; }
        public Single Y { get; init; }
        public Single Z { get; init; }
        #endregion

        #region Operators
        public static Four operator +(Four v) => new Four(+v.W, +v.X, +v.Y, +v.Z);
        public static Four operator +(Four a, Four b) => new Four(a.W + b.W, a.X + b.X, a.Y + b.Y, a.Z + b.Z);
        
        public static Four operator -(Four v) => new Four(-v.W, -v.X, -v.Y, -v.Z);
        public static Four operator -(Four a, Four b) => new Four(a.W - b.W, a.X - b.X, a.Y - b.Y, a.Z - b.Z);
        
        public static Four operator *(Four a, Four b) => new Four(a.W * b.W, a.X * b.X, a.Y * b.Y, a.Z * b.Z);
        public static Four operator *(Four a, Single b) => new Four(a.W * b, a.X * b, a.Y * b, a.Z * b);
        public static Four operator *(Single a, Four b) => new Four(a * b.W, a * b.X, a * b.Y, a * b.Z);

        public static Four operator /(Four a, Four b) => new Four(a.W / b.W, a.X / b.X, a.Y / b.Y, a.Z / b.Z);
        public static Four operator /(Four a, Single b) => new Four(a.W / b, a.X / b, a.Y / b, a.Z / b);
        public static Four operator /(Single a, Four b) => new Four(a / b.W, a / b.X, a / b.Y, a / b.Z);

        public static Four operator %(Four a, Four b) => new Four(a.W % b.W, a.X % b.X, a.Y % b.Y, a.Z % b.Z);
        public static Four operator %(Four a, Single b) => new Four(a.W % b, a.X % b, a.Y % b, a.Z % b);
        public static Four operator %(Single a, Four b) => new Four(a % b.W, a % b.X, a % b.Y, a % b.Z);
        #endregion

        #region Swizzles
        [EditorBrowsable(EditorBrowsableState.Never)] public Two XX { get => new Two(X, X); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Two XY { get => new Two(X, Y); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Two XZ { get => new Two(X, Z); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Two XW { get => new Two(X, W); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Two YX { get => new Two(Y, X); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Two YY { get => new Two(Y, Y); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Two YZ { get => new Two(Y, Z); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Two YW { get => new Two(Y, W); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Two ZX { get => new Two(Z, X); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Two ZY { get => new Two(Z, Y); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Two ZZ { get => new Two(Z, Z); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Two ZW { get => new Two(Z, W); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Two WX { get => new Two(W, X); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Two WY { get => new Two(W, Y); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Two WZ { get => new Two(W, Z); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Two WW { get => new Two(W, W); }

        [EditorBrowsable(EditorBrowsableState.Never)] public Three XXX { get => new Three(X, X, X); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Three XXY { get => new Three(X, X, Y); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Three XXZ { get => new Three(X, X, Z); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Three XXW { get => new Three(X, X, W); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Three XYX { get => new Three(X, Y, X); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Three XYY { get => new Three(X, Y, Y); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Three XYZ { get => new Three(X, Y, Z); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Three XYW { get => new Three(X, Y, W); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Three XZX { get => new Three(X, Z, X); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Three XZY { get => new Three(X, Z, Y); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Three XZZ { get => new Three(X, Z, Z); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Three XZW { get => new Three(X, Z, W); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Three XWX { get => new Three(X, W, X); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Three XWY { get => new Three(X, W, Y); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Three XWZ { get => new Three(X, W, Z); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Three XWW { get => new Three(X, W, W); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Three YXX { get => new Three(Y, X, X); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Three YXY { get => new Three(Y, X, Y); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Three YXZ { get => new Three(Y, X, Z); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Three YXW { get => new Three(Y, X, W); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Three YYX { get => new Three(Y, Y, X); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Three YYY { get => new Three(Y, Y, Y); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Three YYZ { get => new Three(Y, Y, Z); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Three YYW { get => new Three(Y, Y, W); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Three YZX { get => new Three(Y, Z, X); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Three YZY { get => new Three(Y, Z, Y); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Three YZZ { get => new Three(Y, Z, Z); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Three YZW { get => new Three(Y, Z, W); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Three YWX { get => new Three(Y, W, X); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Three YWY { get => new Three(Y, W, Y); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Three YWZ { get => new Three(Y, W, Z); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Three YWW { get => new Three(Y, W, W); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Three ZXX { get => new Three(Z, X, X); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Three ZXY { get => new Three(Z, X, Y); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Three ZXZ { get => new Three(Z, X, Z); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Three ZXW { get => new Three(Z, X, W); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Three ZYX { get => new Three(Z, Y, X); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Three ZYY { get => new Three(Z, Y, Y); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Three ZYZ { get => new Three(Z, Y, Z); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Three ZYW { get => new Three(Z, Y, W); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Three ZZX { get => new Three(Z, Z, X); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Three ZZY { get => new Three(Z, Z, Y); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Three ZZZ { get => new Three(Z, Z, Z); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Three ZZW { get => new Three(Z, Z, W); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Three ZWX { get => new Three(Z, W, X); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Three ZWY { get => new Three(Z, W, Y); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Three ZWZ { get => new Three(Z, W, Z); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Three ZWW { get => new Three(Z, W, W); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Three WXX { get => new Three(W, X, X); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Three WXY { get => new Three(W, X, Y); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Three WXZ { get => new Three(W, X, Z); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Three WXW { get => new Three(W, X, W); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Three WYX { get => new Three(W, Y, X); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Three WYY { get => new Three(W, Y, Y); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Three WYZ { get => new Three(W, Y, Z); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Three WYW { get => new Three(W, Y, W); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Three WZX { get => new Three(W, Z, X); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Three WZY { get => new Three(W, Z, Y); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Three WZZ { get => new Three(W, Z, Z); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Three WZW { get => new Three(W, Z, W); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Three WWX { get => new Three(W, W, X); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Three WWY { get => new Three(W, W, Y); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Three WWZ { get => new Three(W, W, Z); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Three WWW { get => new Three(W, W, W); }

        [EditorBrowsable(EditorBrowsableState.Never)] public Four XXXX { get => new Four(X, X, X, X); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four XXXY { get => new Four(X, X, X, Y); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four XXXZ { get => new Four(X, X, X, Z); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four XXXW { get => new Four(X, X, X, W); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four XXYX { get => new Four(X, X, Y, X); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four XXYY { get => new Four(X, X, Y, Y); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four XXYZ { get => new Four(X, X, Y, Z); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four XXYW { get => new Four(X, X, Y, W); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four XXZX { get => new Four(X, X, Z, X); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four XXZY { get => new Four(X, X, Z, Y); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four XXZZ { get => new Four(X, X, Z, Z); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four XXZW { get => new Four(X, X, Z, W); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four XXWX { get => new Four(X, X, W, X); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four XXWY { get => new Four(X, X, W, Y); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four XXWZ { get => new Four(X, X, W, Z); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four XXWW { get => new Four(X, X, W, W); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four XYXX { get => new Four(X, Y, X, X); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four XYXY { get => new Four(X, Y, X, Y); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four XYXZ { get => new Four(X, Y, X, Z); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four XYXW { get => new Four(X, Y, X, W); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four XYYX { get => new Four(X, Y, Y, X); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four XYYY { get => new Four(X, Y, Y, Y); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four XYYZ { get => new Four(X, Y, Y, Z); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four XYYW { get => new Four(X, Y, Y, W); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four XYZX { get => new Four(X, Y, Z, X); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four XYZY { get => new Four(X, Y, Z, Y); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four XYZZ { get => new Four(X, Y, Z, Z); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four XYZW { get => new Four(X, Y, Z, W); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four XYWX { get => new Four(X, Y, W, X); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four XYWY { get => new Four(X, Y, W, Y); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four XYWZ { get => new Four(X, Y, W, Z); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four XYWW { get => new Four(X, Y, W, W); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four XZXX { get => new Four(X, Z, X, X); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four XZXY { get => new Four(X, Z, X, Y); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four XZXZ { get => new Four(X, Z, X, Z); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four XZXW { get => new Four(X, Z, X, W); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four XZYX { get => new Four(X, Z, Y, X); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four XZYY { get => new Four(X, Z, Y, Y); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four XZYZ { get => new Four(X, Z, Y, Z); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four XZYW { get => new Four(X, Z, Y, W); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four XZZX { get => new Four(X, Z, Z, X); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four XZZY { get => new Four(X, Z, Z, Y); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four XZZZ { get => new Four(X, Z, Z, Z); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four XZZW { get => new Four(X, Z, Z, W); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four XZWX { get => new Four(X, Z, W, X); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four XZWY { get => new Four(X, Z, W, Y); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four XZWZ { get => new Four(X, Z, W, Z); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four XZWW { get => new Four(X, Z, W, W); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four XWXX { get => new Four(X, W, X, X); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four XWXY { get => new Four(X, W, X, Y); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four XWXZ { get => new Four(X, W, X, Z); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four XWXW { get => new Four(X, W, X, W); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four XWYX { get => new Four(X, W, Y, X); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four XWYY { get => new Four(X, W, Y, Y); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four XWYZ { get => new Four(X, W, Y, Z); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four XWYW { get => new Four(X, W, Y, W); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four XWZX { get => new Four(X, W, Z, X); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four XWZY { get => new Four(X, W, Z, Y); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four XWZZ { get => new Four(X, W, Z, Z); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four XWZW { get => new Four(X, W, Z, W); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four XWWX { get => new Four(X, W, W, X); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four XWWY { get => new Four(X, W, W, Y); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four XWWZ { get => new Four(X, W, W, Z); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four XWWW { get => new Four(X, W, W, W); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four YXXX { get => new Four(Y, X, X, X); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four YXXY { get => new Four(Y, X, X, Y); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four YXXZ { get => new Four(Y, X, X, Z); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four YXXW { get => new Four(Y, X, X, W); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four YXYX { get => new Four(Y, X, Y, X); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four YXYY { get => new Four(Y, X, Y, Y); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four YXYZ { get => new Four(Y, X, Y, Z); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four YXYW { get => new Four(Y, X, Y, W); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four YXZX { get => new Four(Y, X, Z, X); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four YXZY { get => new Four(Y, X, Z, Y); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four YXZZ { get => new Four(Y, X, Z, Z); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four YXZW { get => new Four(Y, X, Z, W); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four YXWX { get => new Four(Y, X, W, X); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four YXWY { get => new Four(Y, X, W, Y); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four YXWZ { get => new Four(Y, X, W, Z); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four YXWW { get => new Four(Y, X, W, W); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four YYXX { get => new Four(Y, Y, X, X); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four YYXY { get => new Four(Y, Y, X, Y); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four YYXZ { get => new Four(Y, Y, X, Z); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four YYXW { get => new Four(Y, Y, X, W); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four YYYX { get => new Four(Y, Y, Y, X); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four YYYY { get => new Four(Y, Y, Y, Y); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four YYYZ { get => new Four(Y, Y, Y, Z); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four YYYW { get => new Four(Y, Y, Y, W); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four YYZX { get => new Four(Y, Y, Z, X); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four YYZY { get => new Four(Y, Y, Z, Y); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four YYZZ { get => new Four(Y, Y, Z, Z); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four YYZW { get => new Four(Y, Y, Z, W); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four YYWX { get => new Four(Y, Y, W, X); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four YYWY { get => new Four(Y, Y, W, Y); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four YYWZ { get => new Four(Y, Y, W, Z); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four YYWW { get => new Four(Y, Y, W, W); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four YZXX { get => new Four(Y, Z, X, X); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four YZXY { get => new Four(Y, Z, X, Y); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four YZXZ { get => new Four(Y, Z, X, Z); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four YZXW { get => new Four(Y, Z, X, W); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four YZYX { get => new Four(Y, Z, Y, X); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four YZYY { get => new Four(Y, Z, Y, Y); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four YZYZ { get => new Four(Y, Z, Y, Z); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four YZYW { get => new Four(Y, Z, Y, W); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four YZZX { get => new Four(Y, Z, Z, X); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four YZZY { get => new Four(Y, Z, Z, Y); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four YZZZ { get => new Four(Y, Z, Z, Z); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four YZZW { get => new Four(Y, Z, Z, W); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four YZWX { get => new Four(Y, Z, W, X); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four YZWY { get => new Four(Y, Z, W, Y); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four YZWZ { get => new Four(Y, Z, W, Z); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four YZWW { get => new Four(Y, Z, W, W); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four YWXX { get => new Four(Y, W, X, X); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four YWXY { get => new Four(Y, W, X, Y); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four YWXZ { get => new Four(Y, W, X, Z); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four YWXW { get => new Four(Y, W, X, W); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four YWYX { get => new Four(Y, W, Y, X); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four YWYY { get => new Four(Y, W, Y, Y); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four YWYZ { get => new Four(Y, W, Y, Z); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four YWYW { get => new Four(Y, W, Y, W); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four YWZX { get => new Four(Y, W, Z, X); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four YWZY { get => new Four(Y, W, Z, Y); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four YWZZ { get => new Four(Y, W, Z, Z); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four YWZW { get => new Four(Y, W, Z, W); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four YWWX { get => new Four(Y, W, W, X); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four YWWY { get => new Four(Y, W, W, Y); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four YWWZ { get => new Four(Y, W, W, Z); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four YWWW { get => new Four(Y, W, W, W); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four ZXXX { get => new Four(Z, X, X, X); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four ZXXY { get => new Four(Z, X, X, Y); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four ZXXZ { get => new Four(Z, X, X, Z); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four ZXXW { get => new Four(Z, X, X, W); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four ZXYX { get => new Four(Z, X, Y, X); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four ZXYY { get => new Four(Z, X, Y, Y); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four ZXYZ { get => new Four(Z, X, Y, Z); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four ZXYW { get => new Four(Z, X, Y, W); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four ZXZX { get => new Four(Z, X, Z, X); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four ZXZY { get => new Four(Z, X, Z, Y); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four ZXZZ { get => new Four(Z, X, Z, Z); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four ZXZW { get => new Four(Z, X, Z, W); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four ZXWX { get => new Four(Z, X, W, X); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four ZXWY { get => new Four(Z, X, W, Y); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four ZXWZ { get => new Four(Z, X, W, Z); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four ZXWW { get => new Four(Z, X, W, W); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four ZYXX { get => new Four(Z, Y, X, X); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four ZYXY { get => new Four(Z, Y, X, Y); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four ZYXZ { get => new Four(Z, Y, X, Z); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four ZYXW { get => new Four(Z, Y, X, W); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four ZYYX { get => new Four(Z, Y, Y, X); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four ZYYY { get => new Four(Z, Y, Y, Y); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four ZYYZ { get => new Four(Z, Y, Y, Z); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four ZYYW { get => new Four(Z, Y, Y, W); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four ZYZX { get => new Four(Z, Y, Z, X); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four ZYZY { get => new Four(Z, Y, Z, Y); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four ZYZZ { get => new Four(Z, Y, Z, Z); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four ZYZW { get => new Four(Z, Y, Z, W); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four ZYWX { get => new Four(Z, Y, W, X); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four ZYWY { get => new Four(Z, Y, W, Y); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four ZYWZ { get => new Four(Z, Y, W, Z); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four ZYWW { get => new Four(Z, Y, W, W); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four ZZXX { get => new Four(Z, Z, X, X); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four ZZXY { get => new Four(Z, Z, X, Y); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four ZZXZ { get => new Four(Z, Z, X, Z); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four ZZXW { get => new Four(Z, Z, X, W); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four ZZYX { get => new Four(Z, Z, Y, X); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four ZZYY { get => new Four(Z, Z, Y, Y); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four ZZYZ { get => new Four(Z, Z, Y, Z); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four ZZYW { get => new Four(Z, Z, Y, W); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four ZZZX { get => new Four(Z, Z, Z, X); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four ZZZY { get => new Four(Z, Z, Z, Y); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four ZZZZ { get => new Four(Z, Z, Z, Z); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four ZZZW { get => new Four(Z, Z, Z, W); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four ZZWX { get => new Four(Z, Z, W, X); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four ZZWY { get => new Four(Z, Z, W, Y); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four ZZWZ { get => new Four(Z, Z, W, Z); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four ZZWW { get => new Four(Z, Z, W, W); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four ZWXX { get => new Four(Z, W, X, X); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four ZWXY { get => new Four(Z, W, X, Y); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four ZWXZ { get => new Four(Z, W, X, Z); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four ZWXW { get => new Four(Z, W, X, W); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four ZWYX { get => new Four(Z, W, Y, X); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four ZWYY { get => new Four(Z, W, Y, Y); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four ZWYZ { get => new Four(Z, W, Y, Z); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four ZWYW { get => new Four(Z, W, Y, W); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four ZWZX { get => new Four(Z, W, Z, X); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four ZWZY { get => new Four(Z, W, Z, Y); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four ZWZZ { get => new Four(Z, W, Z, Z); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four ZWZW { get => new Four(Z, W, Z, W); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four ZWWX { get => new Four(Z, W, W, X); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four ZWWY { get => new Four(Z, W, W, Y); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four ZWWZ { get => new Four(Z, W, W, Z); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four ZWWW { get => new Four(Z, W, W, W); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four WXXX { get => new Four(W, X, X, X); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four WXXY { get => new Four(W, X, X, Y); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four WXXZ { get => new Four(W, X, X, Z); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four WXXW { get => new Four(W, X, X, W); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four WXYX { get => new Four(W, X, Y, X); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four WXYY { get => new Four(W, X, Y, Y); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four WXYZ { get => new Four(W, X, Y, Z); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four WXYW { get => new Four(W, X, Y, W); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four WXZX { get => new Four(W, X, Z, X); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four WXZY { get => new Four(W, X, Z, Y); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four WXZZ { get => new Four(W, X, Z, Z); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four WXZW { get => new Four(W, X, Z, W); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four WXWX { get => new Four(W, X, W, X); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four WXWY { get => new Four(W, X, W, Y); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four WXWZ { get => new Four(W, X, W, Z); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four WXWW { get => new Four(W, X, W, W); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four WYXX { get => new Four(W, Y, X, X); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four WYXY { get => new Four(W, Y, X, Y); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four WYXZ { get => new Four(W, Y, X, Z); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four WYXW { get => new Four(W, Y, X, W); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four WYYX { get => new Four(W, Y, Y, X); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four WYYY { get => new Four(W, Y, Y, Y); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four WYYZ { get => new Four(W, Y, Y, Z); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four WYYW { get => new Four(W, Y, Y, W); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four WYZX { get => new Four(W, Y, Z, X); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four WYZY { get => new Four(W, Y, Z, Y); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four WYZZ { get => new Four(W, Y, Z, Z); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four WYZW { get => new Four(W, Y, Z, W); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four WYWX { get => new Four(W, Y, W, X); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four WYWY { get => new Four(W, Y, W, Y); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four WYWZ { get => new Four(W, Y, W, Z); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four WYWW { get => new Four(W, Y, W, W); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four WZXX { get => new Four(W, Z, X, X); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four WZXY { get => new Four(W, Z, X, Y); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four WZXZ { get => new Four(W, Z, X, Z); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four WZXW { get => new Four(W, Z, X, W); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four WZYX { get => new Four(W, Z, Y, X); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four WZYY { get => new Four(W, Z, Y, Y); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four WZYZ { get => new Four(W, Z, Y, Z); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four WZYW { get => new Four(W, Z, Y, W); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four WZZX { get => new Four(W, Z, Z, X); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four WZZY { get => new Four(W, Z, Z, Y); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four WZZZ { get => new Four(W, Z, Z, Z); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four WZZW { get => new Four(W, Z, Z, W); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four WZWX { get => new Four(W, Z, W, X); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four WZWY { get => new Four(W, Z, W, Y); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four WZWZ { get => new Four(W, Z, W, Z); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four WZWW { get => new Four(W, Z, W, W); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four WWXX { get => new Four(W, W, X, X); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four WWXY { get => new Four(W, W, X, Y); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four WWXZ { get => new Four(W, W, X, Z); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four WWXW { get => new Four(W, W, X, W); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four WWYX { get => new Four(W, W, Y, X); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four WWYY { get => new Four(W, W, Y, Y); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four WWYZ { get => new Four(W, W, Y, Z); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four WWYW { get => new Four(W, W, Y, W); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four WWZX { get => new Four(W, W, Z, X); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four WWZY { get => new Four(W, W, Z, Y); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four WWZZ { get => new Four(W, W, Z, Z); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four WWZW { get => new Four(W, W, Z, W); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four WWWX { get => new Four(W, W, W, X); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four WWWY { get => new Four(W, W, W, Y); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four WWWZ { get => new Four(W, W, W, Z); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four WWWW { get => new Four(W, W, W, W); }
        #endregion
    }
    public static Single Dot(this Four a, Four b) => a.W * b.W + a.X * b.X + a.Y * b.Y + a.Z * b.Z;
}
