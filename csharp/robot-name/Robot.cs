using System;
using System.Threading;

public class Robot
{
    const string _digits = "0123456789";
    const string _alphas = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
    public string Name { get; private set; }
    public Robot()
    {
        Name = CreateName();
    }

    public void Reset()
    {
        Name = CreateName();
    }

    string CreateName()
    {
        // If the Random() objects are created quickly, then 
        // these have the same seed value and create the same sequence.
        Thread.Sleep(100);

        var r = new Random();
        var name = new char[] {
            _alphas[r.Next(26)],
            _alphas[r.Next(26)],
            _digits[r.Next(10)],
            _digits[r.Next(10)],
            _digits[r.Next(10)] 
        };
        return new String(name);
    }
}