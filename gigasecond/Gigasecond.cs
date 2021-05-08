using System;

public static class Gigasecond
{
    public static DateTime Add(DateTime moment) => moment.AddSeconds(1000000000);

    public static DateTime AddManual(DateTime moment)
    {
        int mainTime = 1_000_000_000;
        
        var seconds = mainTime % 60;    // remainder in seconds 
        mainTime = mainTime / 60;       // convert time into minutes

        var minutes = mainTime % 60;    // remainder in minutes
        mainTime = mainTime / 60;       // convert time into hours

        var hours = mainTime % 24;      // remainder in hours
        mainTime = mainTime / 24;       // convert time into days

        return moment.Add(new TimeSpan(mainTime, hours, minutes, seconds));
    }
}