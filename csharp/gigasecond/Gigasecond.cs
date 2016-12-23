using System;

public class Gigasecond 
{
    public static DateTime Date(DateTime born) 
    {
        return born.AddSeconds(1000000000);
    }
}