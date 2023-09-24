//https://localhost:7130/api/time/time
using System;

public class ServiceTime
{
    public string GetTime()
    {
        var currentTime = DateTime.Now;
        var hour = currentTime.Hour;

        if (hour >= 6 && hour < 12)
        {
            return "Зараз ранок";
        }
        else if (hour >= 12 && hour < 18)
        {
            return "Зараз день";
        }
        else if (hour >= 18 && hour < 24)
        {
            return "Зараз вечір";
        }
        else
        {
            return "Зараз ніч";
        }
    }
}
