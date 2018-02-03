using System;
public class Common
{
    public static long Time()
    {
        DateTime dt1 = new DateTime(1970, 1, 1);
        TimeSpan ts = DateTime.Now - dt1;
        return (long)ts.TotalDays;
    }
}