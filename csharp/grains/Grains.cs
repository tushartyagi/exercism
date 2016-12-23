public class Grains
{
    public static ulong Total() 
    {
        return 2 * Square(64) - 1;
    }

    public static ulong Square(int n)
    {
        if (n == 1) return 1;
        return 2 * Square(n - 1);
    }
}