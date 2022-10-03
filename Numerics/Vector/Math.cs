namespace Roxijn.Numerics;

using static Roxijn.Numerics.Vector;

public static partial class Math
{
    public static Two Abs(this Two v) => new Two(Abs(v.x), Abs(v.y));
    public static Three Abs(this Three v) => new Three(Abs(v.x), Abs(v.y), Abs(v.z));
    public static Four Abs(this Four v) => new Four(Abs(v.w), Abs(v.x), Abs(v.y), Abs(v.z));

    public static Two ArcCos(this Two v) => new Two(ArcCos(v.x), ArcCos(v.y));
    public static Three ArcCos(this Three v) => new Three(ArcCos(v.x), ArcCos(v.y), ArcCos(v.z));
    public static Four ArcCos(this Four v) => new Four(ArcCos(v.w), ArcCos(v.x), ArcCos(v.y), ArcCos(v.z));

    public static Two ArCosH(this Two v) => new Two(ArCosH(v.x), ArCosH(v.y));
    public static Three ArCosH(this Three v) => new Three(ArCosH(v.x), ArCosH(v.y), ArCosH(v.z));
    public static Four ArCosH(this Four v) => new Four(ArCosH(v.w), ArCosH(v.x), ArCosH(v.y), ArCosH(v.z));

    public static Two ArcSin(this Two v) => new Two(ArcSin(v.x), ArcSin(v.y));
    public static Three ArcSin(this Three v) => new Three(ArcSin(v.x), ArcSin(v.y), ArcSin(v.z));
    public static Four ArcSin(this Four v) => new Four(ArcSin(v.w), ArcSin(v.x), ArcSin(v.y), ArcSin(v.z));

    public static Two ArSinH(this Two v) => new Two(ArSinH(v.x), ArSinH(v.y));
    public static Three ArSinH(this Three v) => new Three(ArSinH(v.x), ArSinH(v.y), ArSinH(v.z));
    public static Four ArSinH(this Four v) => new Four(ArSinH(v.w), ArSinH(v.x), ArSinH(v.y), ArSinH(v.z));

    public static Two ArcTan(this Two v) => new Two(ArcTan(v.x), ArcTan(v.y));
    public static Three ArcTan(this Three v) => new Three(ArcTan(v.x), ArcTan(v.y), ArcTan(v.z));
    public static Four ArcTan(this Four v) => new Four(ArcTan(v.w), ArcTan(v.x), ArcTan(v.y), ArcTan(v.z));

    public static Two ArcTan(this Two v1, Two v2) => new Two(ArcTan(v1.x, v2.x), ArcTan(v1.y, v2.y));
    public static Three ArcTan(this Three v1, Three v2) => new Three(ArcTan(v1.x, v2.x), ArcTan(v1.y, v2.y), ArcTan(v1.z, v2.z));
    public static Four ArcTan(this Four v1, Four v2) => new Four(ArcTan(v1.w, v2.w), ArcTan(v1.x, v2.x), ArcTan(v1.y, v2.y), ArcTan(v1.z, v2.z));

    public static Two Ceil(this Two v) => new Two(Ceil(v.x), Ceil(v.y));
    public static Three Ceil(this Three v) => new Three(Ceil(v.x), Ceil(v.y), Ceil(v.z));
    public static Four Ceil(this Four v) => new Four(Ceil(v.w), Ceil(v.x), Ceil(v.y), Ceil(v.z));

    public static Two Clamp(this Two v, float min, float max) => new Two(Clamp(v.x, min, max), Clamp(v.y, min, max));
    public static Three Clamp(this Three v, float min, float max) => new Three(Clamp(v.x, min, max), Clamp(v.y, min, max), Clamp(v.z, min, max));
    public static Four Clamp(this Four v, float min, float max) => new Four(Clamp(v.w, min, max), Clamp(v.x, min, max), Clamp(v.y, min, max), Clamp(v.z, min, max));

    public static Three Cross(this Three a, Three b) => new Three(a.y * b.z - a.z * b.y, a.z * b.x - a.x * b.z, a.x * b.y - a.y * b.x);

    public static float Dot(this Two a, Two b) => a.x * b.x + a.y * b.y;
    public static float Dot(this Three a, Three b) => a.x * b.x + a.y * b.y + a.z * b.z;
    public static float Dot(this Four a, Four b) => a.w * b.w + a.x * b.x + a.y * b.y + a.z * b.z;

    public static float Distance(this Two a, Two b) => Magnitude(b - a);
    public static float Distance(this Three a, Three b) => Magnitude(b - a);
    public static float Distance(this Four a, Four b) => Magnitude(b - a);

    public static float SqrDistance(this Two a, Two b) => SqrMagnitude(b - a);
    public static float SqrDistance(this Three a, Three b) => SqrMagnitude(b - a);
    public static float SqrDistance(this Four a, Four b) => SqrMagnitude(b - a);

    public static Two Exp(this Two v) => new Two(Exp(v.x), Exp(v.y));
    public static Three Exp(this Three v) => new Three(Exp(v.x), Exp(v.y), Exp(v.z));
    public static Four Exp(this Four v) => new Four(Exp(v.w), Exp(v.x), Exp(v.y), Exp(v.z));

    public static Two Floor(this Two v) => new Two(Floor(v.x), Floor(v.y));
    public static Three Floor(this Three v) => new Three(Floor(v.x), Floor(v.y), Floor(v.z));
    public static Four Floor(this Four v) => new Four(Floor(v.w), Floor(v.x), Floor(v.y), Floor(v.z));

    public static float Magnitude(this Two v) => Sqrt(SqrMagnitude(v));
    public static float Magnitude(this Three v) => Sqrt(SqrMagnitude(v));
    public static float Magnitude(this Four v) => Sqrt(SqrMagnitude(v));

    public static Two Max(this Two v1, Two v2) => new Two(Max(v1.x, v2.x), Max(v1.y, v2.y));
    public static Three Max(this Three v1, Three v2) => new Three(Max(v1.x, v2.x), Max(v1.y, v2.y), Max(v1.z, v2.z));
    public static Four Max(this Four v1, Four v2) => new Four(Max(v1.w, v2.w), Max(v1.x, v2.x), Max(v1.y, v2.y), Max(v1.z, v2.z));

    public static Two Min(this Two v1, Two v2) => new Two(Min(v1.x, v2.x), Min(v1.y, v2.y));
    public static Three Min(this Three v1, Three v2) => new Three(Min(v1.x, v2.x), Min(v1.y, v2.y), Min(v1.z, v2.z));
    public static Four Min(this Four v1, Four v2) => new Four(Min(v1.w, v2.w), Min(v1.x, v2.x), Min(v1.y, v2.y), Min(v1.z, v2.z));

    public static Two Lerp(this Two v1, Two v2, Two a) => new Two(Lerp(v1.x, v2.x, a.x), Lerp(v1.y, v2.y, a.y));
    public static Three Lerp(this Three v1, Three v2, Three a) => new Three(Lerp(v1.x, v2.x, a.x), Lerp(v1.y, v2.y, a.y), Lerp(v1.z, v2.z, a.z));
    public static Four Lerp(this Four v1, Four v2, Four a) => new Four(Lerp(v1.w, v2.w, a.w), Lerp(v1.x, v2.x, a.x), Lerp(v1.y, v2.y, a.y), Lerp(v1.z, v2.z, a.z));
    public static Two Lerp(this Two v1, Two v2, float a) => new Two(Lerp(v1.x, v2.x, a), Lerp(v1.y, v2.y, a));
    public static Three Lerp(this Three v1, Three v2, float a) => new Three(Lerp(v1.x, v2.x, a), Lerp(v1.y, v2.y, a), Lerp(v1.z, v2.z, a));
    public static Four Lerp(this Four v1, Four v2, float a) => new Four(Lerp(v1.w, v2.w, a), Lerp(v1.x, v2.x, a), Lerp(v1.y, v2.y, a), Lerp(v1.z, v2.z, a));

    public static Two LogE(this Two v) => new Two(LogE(v.x), LogE(v.y));
    public static Three LogE(this Three v) => new Three(LogE(v.x), LogE(v.y), LogE(v.z));
    public static Four LogE(this Four v) => new Four(LogE(v.w), LogE(v.x), LogE(v.y), LogE(v.z));

    public static Two Log2(this Two v) => new Two(Log2(v.x), Log2(v.y));
    public static Three Log2(this Three v) => new Three(Log2(v.x), Log2(v.y), Log2(v.z));
    public static Four Log2(this Four v) => new Four(Log2(v.w), Log2(v.x), Log2(v.y), Log2(v.z));

    public static Two Log10(this Two v) => new Two(Log10(v.x), Log10(v.y));
    public static Three Log10(this Three v) => new Three(Log10(v.x), Log10(v.y), Log10(v.z));
    public static Four Log10(this Four v) => new Four(Log10(v.w), Log10(v.x), Log10(v.y), Log10(v.z));

    public static Two Pow(this Two v1, Two v2) => new Two(Pow(v1.x, v2.x), Pow(v1.y, v2.y));
    public static Three Pow(this Three v1, Three v2) => new Three(Pow(v1.x, v2.x), Pow(v1.y, v2.y), Pow(v1.z, v2.z));
    public static Four Pow(this Four v1, Four v2) => new Four(Pow(v1.w, v2.w), Pow(v1.x, v2.x), Pow(v1.y, v2.y), Pow(v1.z, v2.z));

    public static Two Project(this Two a, Two b) => b * Dot(a, b) / SqrMagnitude(b);
    public static Three Project(this Three a, Three b) => b * Dot(a, b) / SqrMagnitude(b);
    public static Four Project(this Four a, Four b) => b * Dot(a, b) / SqrMagnitude(b);

    public static Two Reject(this Two a, Two b) => a - Project(a, b);
    public static Three Reject(this Three a, Three b) => a - Project(a, b);
    public static Four Reject(this Four a, Four b) => a - Project(a, b);

    public static Two Round(this Two v) => new Two(Round(v.x), Round(v.y));
    public static Three Round(this Three v) => new Three(Round(v.x), Round(v.y), Round(v.z));
    public static Four Round(this Four v) => new Four(Round(v.w), Round(v.x), Round(v.y), Round(v.z));

    public static Two Sign(this Two v) => new Two(Sign(v.x), Sign(v.y));
    public static Three Sign(this Three v) => new Three(Sign(v.x), Sign(v.y), Sign(v.z));
    public static Four Sign(this Four v) => new Four(Sign(v.w), Sign(v.x), Sign(v.y), Sign(v.z));

    public static Two SmoothStep(this Two v1, Two v2, Two a) => new Two(SmoothStep(v1.x, v2.x, a.x), SmoothStep(v1.y, v2.y, a.y));
    public static Three SmoothStep(this Three v1, Three v2, Three a) => new Three(SmoothStep(v1.x, v2.x, a.x), SmoothStep(v1.y, v2.y, a.y), SmoothStep(v1.z, v2.z, a.z));
    public static Four SmoothStep(this Four v1, Four v2, Four a) => new Four(SmoothStep(v1.w, v2.w, a.w), SmoothStep(v1.x, v2.x, a.x), SmoothStep(v1.y, v2.y, a.y), SmoothStep(v1.z, v2.z, a.z));
    public static Two SmoothStep(this Two v1, Two v2, float a) => new Two(SmoothStep(v1.x, v2.x, a), SmoothStep(v1.y, v2.y, a));
    public static Three SmoothStep(this Three v1, Three v2, float a) => new Three(SmoothStep(v1.x, v2.x, a), SmoothStep(v1.y, v2.y, a), SmoothStep(v1.z, v2.z, a));
    public static Four SmoothStep(this Four v1, Four v2, float a) => new Four(SmoothStep(v1.w, v2.w, a), SmoothStep(v1.x, v2.x, a), SmoothStep(v1.y, v2.y, a), SmoothStep(v1.z, v2.z, a));

    public static Two SmootherStep(this Two v1, Two v2, Two a) => new Two(SmootherStep(v1.x, v2.x, a.x), SmootherStep(v1.y, v2.y, a.y));
    public static Three SmootherStep(this Three v1, Three v2, Three a) => new Three(SmootherStep(v1.x, v2.x, a.x), SmootherStep(v1.y, v2.y, a.y), SmootherStep(v1.z, v2.z, a.z));
    public static Four SmootherStep(this Four v1, Four v2, Four a) => new Four(SmootherStep(v1.w, v2.w, a.w), SmootherStep(v1.x, v2.x, a.x), SmootherStep(v1.y, v2.y, a.y), SmootherStep(v1.z, v2.z, a.z));
    public static Two SmootherStep(this Two v1, Two v2, float a) => new Two(SmootherStep(v1.x, v2.x, a), SmootherStep(v1.y, v2.y, a));
    public static Three SmootherStep(this Three v1, Three v2, float a) => new Three(SmootherStep(v1.x, v2.x, a), SmootherStep(v1.y, v2.y, a), SmootherStep(v1.z, v2.z, a));
    public static Four SmootherStep(this Four v1, Four v2, float a) => new Four(SmootherStep(v1.w, v2.w, a), SmootherStep(v1.x, v2.x, a), SmootherStep(v1.y, v2.y, a), SmootherStep(v1.z, v2.z, a));

    public static float SqrMagnitude(this Two v) => Dot(v, v);
    public static float SqrMagnitude(this Three v) => Dot(v, v);
    public static float SqrMagnitude(this Four v) => Dot(v, v);

    public static Two Sqrt(this Two v) => new Two(Sqrt(v.x), Sqrt(v.y));
    public static Three Sqrt(this Three v) => new Three(Sqrt(v.x), Sqrt(v.y), Sqrt(v.z));
    public static Four Sqrt(this Four v) => new Four(Sqrt(v.w), Sqrt(v.x), Sqrt(v.y), Sqrt(v.z));

    public static Two Step(this Two v, Two edge) => new Two(Step(v.x, edge.x), Step(v.y, edge.y));
    public static Three Step(this Three v, Three edge) => new Three(Step(v.x, edge.x), Step(v.y, edge.y), Step(v.z, edge.z));
    public static Four Step(this Four v, Four edge) => new Four(Step(v.w, edge.w), Step(v.x, edge.x), Step(v.y, edge.y), Step(v.z, edge.z));
    public static Two Step(this Two v, float edge) => new Two(Step(v.x, edge), Step(v.y, edge));
    public static Three Step(this Three v, float edge) => new Three(Step(v.x, edge), Step(v.y, edge), Step(v.z, edge));
    public static Four Step(this Four v, float edge) => new Four(Step(v.w, edge), Step(v.x, edge), Step(v.y, edge), Step(v.z, edge));

    public static Two Truncate(this Two v) => new Two(Truncate(v.x), Truncate(v.y));
    public static Three Truncate(this Three v) => new Three(Truncate(v.x), Truncate(v.y), Truncate(v.z));
    public static Four Truncate(this Four v) => new Four(Truncate(v.w), Truncate(v.x), Truncate(v.y), Truncate(v.z));

    public static Two Unit(this Two v) => v / Magnitude(v);
    public static Three Unit(this Three v) => v / Magnitude(v);
    public static Four Unit(this Four v) => v / Magnitude(v);
}
