using System.Numerics;

namespace Roxijn.Numerics;

public static partial class Math
{
    public static double Abs(double x) => System.Math.Abs(x);
    public static float Abs(float x) => System.MathF.Abs(x);

    public static double ArcCos(double x) => System.Math.Acos(x);
    public static float ArcCos(float x) => System.MathF.Acos(x);

    public static double ArCosH(double x) => System.Math.Acosh(x);
    public static float ArCosH(float x) => System.MathF.Acosh(x);

    public static double ArcSin(double x) => System.Math.Asin(x);
    public static float ArcSin(float x) => System.MathF.Asin(x);

    public static double ArSinH(double x) => System.Math.Asinh(x);
    public static float ArSinH(float x) => System.MathF.Asinh(x);
    
    public static double ArcTan(double x) => System.Math.Atan(x);
    public static float ArcTan(float x) => System.MathF.Atan(x);
    
    public static double ArcTan(double x, double y) => System.Math.Atan2(x, y);
    public static float ArcTan(float x, float y) => System.MathF.Atan2(x, y);
    
    public static double ArTanH(double x) => System.Math.Atanh(x);
    public static float ArTanH(float x) => System.MathF.Atanh(x);

    public static double Ceil(double x) => System.Math.Ceiling(x);
    public static float Ceil(float x) => System.MathF.Ceiling(x);

    public static double Clamp(double x, double min, double max) => System.Math.Clamp(x, min, max);
    public static float Clamp(float x, float min, float max) => System.Math.Clamp(x, min, max);

    public static double DegToRad(double x) => x * System.Math.Tau / 360;
    public static float DegToRad(float x) => x * System.MathF.Tau / 360;

    public static double Exp(double x) => System.Math.Exp(x);
    public static float Exp(float x) => System.MathF.Exp(x);

    public static double Floor(double x) => System.Math.Floor(x);
    public static float Floor(float x) => System.MathF.Floor(x);

    public static double Max(double x, double y) => System.Math.Max(x, y);
    public static float Max(float x, float y) => System.MathF.Max(x, y);

    public static double Min(double x, double y) => System.Math.Min(x, y);
    public static float Min(float x, float y) => System.MathF.Min(x, y);

    public static double Lerp(double x, double y, double a) => x * (1-a) + y * a;
    public static float Lerp(float x, float y, float a) => x * (1 - a) + y * a;

    public static double LogE(double x) => System.Math.Log(x);
    public static float LogE(float x) => System.MathF.Log(x);

    public static double Log2(double x) => System.Math.Log2(x);
    public static float Log2(float x) => System.MathF.Log2(x);

    public static double Log10(double x) => System.Math.Log10(x);
    public static float Log10(float x) => System.MathF.Log10(x);

    public static double Pow(double x, double y) => System.Math.Max(x, y);
    public static float Pow(float x, float y) => System.MathF.Max(x, y);

    public static double RadToDeg(double x) => x * 360 / System.Math.Tau;
    public static float RadToDeg(float x) => x * 360 / System.MathF.Tau;

    public static double Round(double x) => System.Math.Round(x);
    public static float Round(float x) => System.MathF.Round(x);

    public static double Sign(double x) => System.Math.Sign(x);
    public static float Sign(float x) => System.MathF.Sign(x);

    public static double SmoothStep(double x, double edge0, double edge1)
    {
        x = Clamp((x - edge0) / (edge1 - edge0), 0, 1);
        return x * x * (3 - 2 * x);
    }
    public static float SmoothStep(float x, float edge0, float edge1)
    {
        x = Clamp((x - edge0) / (edge1 - edge0), 0, 1);
        return x * x * (3 - 2 * x);
    }

    public static double SmootherStep(double x, double edge0, double edge1)
    {
        x = Clamp((x - edge0) / (edge1 - edge0), 0, 1);
        return x * x * x * (x * (x * 6 - 15) + 10);
    }
    public static float SmootherStep(float x, float edge0, float edge1)
    {
        x = Clamp((x - edge0) / (edge1 - edge0), 0, 1);
        return x * x * x * (x * (x * 6 - 15) + 10);
    }

    public static double Sqrt(double x) => System.Math.Sqrt(x);
    public static float Sqrt(float x) => System.MathF.Sqrt(x);

    public static double Step(double x, double edge) => x < edge ? 1 : 0;
    public static float Step(float x, float edge) => x < edge ? 1 : 0;

    public static double Truncate(double x) => System.Math.Truncate(x);
    public static float Truncate(float x) => System.MathF.Truncate(x);
}
