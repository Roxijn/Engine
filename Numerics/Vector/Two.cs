using System.ComponentModel;

namespace Roxijn.Numerics;

public static partial class Vector
{
    public readonly struct Two
    {
        #region Constructors
        public Two(Single X = 0, Single Y = 0)
        {
            this.X = X; this.Y = Y;
        }

        public Single X { get; init; }
        public Single Y { get; init; }
        #endregion

        #region Operators
        public static Two operator +(Two v) => new Two(+v.X, +v.Y);
        public static Two operator +(Two a, Two b) => new Two(a.X + b.X, a.Y + b.Y);

        public static Two operator -(Two v) => new Two(-v.X, -v.Y);
        public static Two operator -(Two a, Two b) => new Two(a.X - b.X, a.Y - b.Y);

        public static Two operator *(Two a, Two b) => new Two(a.X * b.X, a.Y * b.Y);
        public static Two operator *(Two a, Single b) => new Two(a.X * b, a.Y * b);
        public static Two operator *(Single a, Two b) => new Two(a * b.X, a * b.Y);

        public static Two operator /(Two a, Two b) => new Two(a.X / b.X, a.Y / b.Y);
        public static Two operator /(Two a, Single b) => new Two(a.X / b, a.Y / b);
        public static Two operator /(Single a, Two b) => new Two(a / b.X, a / b.Y);

        public static Two operator %(Two a, Two b) => new Two(a.X % b.X, a.Y % b.Y);
        public static Two operator %(Single a, Two b) => new Two(a % b.X, a% b.Y);
        public static Two operator %(Two a, Single b) => new Two(a.X % b, a.Y % b);
        #endregion

        #region Swizzles
        [EditorBrowsable(EditorBrowsableState.Never)] public Two XX { get => new Two(X, X); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Two XY { get => new Two(X, Y); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Two YX { get => new Two(Y, X); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Two YY { get => new Two(Y, Y); }

        [EditorBrowsable(EditorBrowsableState.Never)] public Three XXX { get => new Three(X, X, X); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Three XXY { get => new Three(X, X, Y); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Three XYX { get => new Three(X, Y, X); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Three XYY { get => new Three(X, Y, Y); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Three YXX { get => new Three(Y, X, X); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Three YXY { get => new Three(Y, X, Y); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Three YYX { get => new Three(Y, Y, X); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Three YYY { get => new Three(Y, Y, Y); }

        [EditorBrowsable(EditorBrowsableState.Never)] public Four XXXX { get => new Four(X, X, X, X); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four XXXY { get => new Four(X, X, X, Y); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four XXYX { get => new Four(X, X, Y, X); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four XXYY { get => new Four(X, X, Y, Y); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four XYXX { get => new Four(X, Y, X, X); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four XYXY { get => new Four(X, Y, X, Y); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four XYYX { get => new Four(X, Y, Y, X); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four XYYY { get => new Four(X, Y, Y, Y); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four YXXX { get => new Four(Y, X, X, X); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four YXXY { get => new Four(Y, X, X, Y); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four YXYX { get => new Four(Y, X, Y, X); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four YXYY { get => new Four(Y, X, Y, Y); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four YYXX { get => new Four(Y, Y, X, X); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four YYXY { get => new Four(Y, Y, X, Y); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four YYYX { get => new Four(Y, Y, Y, X); }
        [EditorBrowsable(EditorBrowsableState.Never)] public Four YYYY { get => new Four(Y, Y, Y, Y); }
        #endregion
    }

    public static Two Abs(this Two v) => new Two(MathF.Abs(v.X), MathF.Abs(v.Y));
    public static Two Ceiling(this Two v) => new Two(MathF.Ceiling(v.X), MathF.Ceiling(v.Y));
    public static Single Dot(this Two a, Two b) => a.X * b.X + a.Y * b.Y;
    public static Two Floor(this Two v) => new Two(MathF.Floor(v.X), MathF.Floor(v.Y));
    public static Two Lerp(this Two a, Two b, Single w) => a + (b - a) * w;
    public static Single Magnitude(this Two v) => MathF.Sqrt(SquareMagnitude(v));
    private static Two Reflect(Two v, Two n) => 2 * Dot(v, n) * n - v;
    public static Two Round(this Two v) => new Two(MathF.Round(v.X), MathF.Round(v.Y));
    public static Two Sign(this Two v) => new Two(MathF.Sign(v.X), MathF.Sign(v.Y));
    public static Single SquareMagnitude(this Two v) => Dot(v, v);
    public static Two Unit(this Two v) => v / Magnitude(v);
}
