using System;


class Program
{
    enum DayTime
    {
        Morning, 
        Afternoon, 
        Evening, 
        Night 
    }
    static void Main()
    {
        DayTime daytime = DayTime.Morning;
        if(daytime == DayTime.Morning) System.Console.WriteLine("Доброе утро");
        else if(daytime == DayTime.Night) System.Console.WriteLine("Ночь");
    }
}
