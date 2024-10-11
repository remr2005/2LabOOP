/// <summary>
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
}
