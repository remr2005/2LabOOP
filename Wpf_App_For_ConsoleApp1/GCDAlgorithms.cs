﻿/// <summary>
/// Class for GCD
/// </summary>
public class GCDAlgorithms
{
    /// <summary>
    /// The function for gcd
    /// </summary>
    /// <param name="a">first number</param>
    /// <param name="b">second number</param>
    /// <returns>return GCD for a and b</returns>
    public static int FindGCDEuclid(int a, int b)
    {
        if (a == 0) return b;
        if (b == 0) return a;
        if (a>b) return FindGCDEuclid(a-b*(a/b),b);
        return FindGCDEuclid(a,b-a*(b/a));
    }
    /// <summary>
    /// The function for gcd
    /// </summary>
    /// <param name="a">first number</param>
    /// <param name="b">second number</param>
    /// <param name="c">third number</param>
    /// <returns>return GCD for a and b</returns>
    public static int FindGCDEuclid(int a, int b, int c)
    {
        return FindGCDEuclid(FindGCDEuclid(a, b), c);
    }
    /// <summary>
    /// The function for gcd
    /// </summary>
    /// <param name="a">first number</param>
    /// <param name="b">second number</param>
    /// <param name="c">third number</param>
    /// <param name="d">fourth number</param>
    /// <returns>return GCD for a and b</returns>
    public static int FindGCDEuclid(int a, int b, int c, int d)
    {
        return FindGCDEuclid(FindGCDEuclid(a, b), c, d);
    }
    /// <summary>
    /// The function for gcd
    /// </summary>
    /// <param name="a">first number</param>
    /// <param name="b">second number</param>
    /// <param name="c">third number</param>
    /// <param name="d">fourth number</param>
    /// <param name="f">fifth number</param>
    /// <returns>return GCD for a and b</returns>
    public static int FindGCDEuclid(int a, int b, int c, int d, int f)
    {
        return FindGCDEuclid(a,b,c,FindGCDEuclid(d,f));
    }
    /// <summary>
    /// The Stein function for GCD
    /// </summary>
    /// <param name="a">First number</param>
    /// <param name="b">Second number</param>
    /// <returns>Return GCD</returns>
    public static int FindGCDStein(int a, int b)
    {
        if (a == 0 || b == 0) return a | b;
        if ( a%2 + b%2 == 0 ) return FindGCDStein(a>>1,b>>1)<<1;
        if (a%2==0) return FindGCDStein(a>>1,b);
        if (b%2==0) return FindGCDStein(a, b>>1);
        if (a >= b) return FindGCDStein((a - b) >> 1, b);
        return FindGCDStein((b-a)>>1,a);
    }
    /// <summary>
    /// The Stein function for GCD
    /// </summary>
    /// <param name="a">First number</param>
    /// <param name="b">Second number</param>
    /// <param name="c">Third number</param>
    /// <returns>Return GCD</returns>
    public static int FindGCDStein(int a, int b, int c)
    {
        return FindGCDStein(a, FindGCDStein(b,c));
    }
    /// <summary>
    /// The Stein function for GCD
    /// </summary>
    /// <param name="a">First number</param>
    /// <param name="b">Second number</param>
    /// <param name="c">Third number</param>
    /// <param name="d">Fourth number</param>
    /// <returns>Return GCD</returns>
    public static int FindGCDStein(int a, int b, int c, int d)
    {
        return FindGCDStein(FindGCDStein(a,b), c,d);
    }
    /// <summary>
    /// The Stein function for GCD
    /// </summary>
    /// <param name="a">First number</param>
    /// <param name="b">Second number</param>
    /// <param name="c">Third number</param>
    /// <param name="d">Fourth number</param>
    /// <param name="f">Fifth number</param>
    /// <returns>Return GCD</returns>
    public static int FindGCDStein(int a, int b, int c, int d, int f)
    {
        return FindGCDStein(FindGCDStein(a, b), c, d, f);
    }
}
