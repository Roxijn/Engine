namespace Roxijn.Numerics;

using System;
using static Roxijn.Numerics.Matrix;

public static partial class Math
{
    public static float Determinant(this Two m) => m.a * m.d - m.b * m.c;

    public static float Determinant(this Three m)
    {
        var ei_fh = m.e * m.i - m.f * m.h;
        var di_fg = m.d * m.i - m.f * m.g;
        var dh_eg = m.d * m.h - m.e * m.g;

        return m.a * ei_fh - m.b * di_fg + m.c * dh_eg;
    }

    public static float Determinant(this Four m)
    {
        var kp_lo = m.k * m.p - m.l * m.o;
        var jp_ln = m.j * m.p - m.l * m.n;
        var jo_kn = m.j * m.o - m.k * m.n;
        var ip_lm = m.i * m.p - m.l * m.m;
        var io_km = m.i * m.o - m.k * m.m;
        var in_jm = m.i * m.n - m.j * m.m;

        var a11 = m.f * kp_lo - m.g * jp_ln + m.h * jo_kn;
        var a12 = m.e * kp_lo - m.g * ip_lm + m.h * io_km;
        var a13 = m.e * jp_ln - m.f * ip_lm + m.h * in_jm;
        var a14 = m.e * jo_kn - m.f * io_km + m.g * in_jm;

        return m.a * a11 - m.b * a12 + m.c * a13 - m.d * a14;
    }

    public static Two Inverse(this Two m)
    {
        var det = Determinant(m);

        if (det < float.Epsilon) throw new ArithmeticException("Matrix is singular");

        var invDet = 1 / det;

        return new Two(
            invDet * m.d, -invDet * m.c,
            -invDet * m.b, invDet * m.a
        );
    }

    public static Three Inverse(this Three m)
    {
        //calculatate adjoint
        var ei_fh = m.e * m.i - m.f * m.h;
        var di_fg = m.d * m.i - m.f * m.g;
        var dh_eg = m.d * m.h - m.e * m.g;

        //early exit
        var det = m.a * ei_fh
            - m.b * di_fg
            + m.c * dh_eg;

        if (det < float.Epsilon) throw new ArithmeticException("Matrix is singular");

        var invDet = 1 / det;

        var bi_ch = m.b * m.i - m.c * m.h;
        var ai_cg = m.a * m.i - m.c * m.g;
        var ah_bg = m.a * m.h - m.b * m.g;

        var bf_ce = m.b * m.f - m.c * m.e;
        var bf_cd = m.b * m.f - m.c * m.d;
        var ae_bd = m.a * m.e - m.b * m.d;

        return new Three(
            invDet * ei_fh, -invDet * di_fg, invDet * dh_eg,
            -invDet * bi_ch, invDet * ai_cg, -invDet * ah_bg,
            invDet * bf_ce, -invDet * bf_cd, invDet * ae_bd
        );
    }

    public static Four Inverse(this Four m)
    {
        //calculate cofactors
        var kp_lo = m.k * m.p - m.l * m.o;
        var jp_ln = m.j * m.p - m.l * m.n;
        var jo_kn = m.j * m.o - m.k * m.n;
        var ip_lm = m.i * m.p - m.l * m.m;
        var io_km = m.i * m.o - m.k * m.m;
        var in_jm = m.i * m.n - m.j * m.m;

        var a11 = m.f * kp_lo - m.g * jp_ln + m.h * jo_kn;
        var a12 = m.e * kp_lo - m.g * ip_lm + m.h * io_km;
        var a13 = m.e * jp_ln - m.f * ip_lm + m.h * in_jm;
        var a14 = m.e * jo_kn - m.f * io_km + m.g * in_jm;

        //early exit
        var det = m.a * a11 - m.b * a12 + m.c * a12 - m.d * a14;

        if (det < float.Epsilon) throw new ArithmeticException("Matrix is singular");

        var invdet = 1 / det;

        var a21 = m.b * kp_lo - m.c * jp_ln + m.d * jo_kn;
        var a22 = m.a * kp_lo - m.c * ip_lm + m.d * io_km;
        var a23 = m.a * jp_ln - m.b * ip_lm + m.d * in_jm;
        var a24 = m.a * jo_kn - m.b * io_km + m.d * in_jm;

        var gp_ho = m.g * m.p - m.h * m.o;
        var fp_hn = m.f * m.p - m.h * m.n;
        var fo_gn = m.f * m.o - m.g * m.n;
        var ep_hm = m.e * m.p - m.h * m.m;
        var eo_gm = m.e * m.o - m.g * m.m;
        var en_fm = m.e * m.n - m.f * m.m;

        var a31 = m.b * gp_ho - m.c * fp_hn + m.d * fo_gn;
        var a32 = m.a * gp_ho - m.c * ep_hm + m.d * eo_gm;
        var a33 = m.a * gp_ho - m.b * ep_hm + m.d * en_fm;
        var a34 = m.a * fo_gn - m.b * eo_gm + m.c * en_fm;

        float gl_hk = m.g * m.l - m.h * m.k;
        float fl_hj = m.f * m.l - m.h * m.j;
        float fk_gj = m.f * m.k - m.g * m.j;
        float el_hi = m.e * m.l - m.h * m.i;
        float ek_gi = m.e * m.k - m.g * m.i;
        float ej_fi = m.e * m.j - m.f * m.i;

        var a41 = m.b * gl_hk - m.c * fl_hj + m.d * fk_gj;
        var a42 = m.a * gl_hk - m.c * el_hi + m.d * ek_gi;
        var a43 = m.a * fl_hj - m.b * el_hi + m.d * ej_fi;
        var a44 = m.a * fk_gj - m.b * ek_gi + m.c * ej_fi;

        return new Four(
            invdet * a11, -invdet * a21, invdet * a31, -invdet * a41,
            -invdet * a12, invdet * a22, -invdet * a32, invdet * a42,
            invdet * a13, -invdet * a23, invdet * a33, -invdet * a43,
            -invdet * a14, invdet * a24, -invdet * a34, invdet * a44
        );
    }

    public static Two Transpose(this Two m) => new Two(
        m.a, m.c,
        m.b, m.d);
    public static Three Transpose(this Three m) => new Three(
        m.a, m.d, m.g,
        m.b, m.e, m.h,
        m.c, m.f, m.i);
    public static Four Transpose(this Four m) => new Four(
        m.a, m.e, m.i, m.m,
        m.b, m.f, m.j, m.n,
        m.c, m.g, m.k, m.o,
        m.d, m.h, m.l, m.p);
}