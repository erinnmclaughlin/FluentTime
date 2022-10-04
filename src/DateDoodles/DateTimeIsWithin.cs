namespace DateDoodles;

public interface IDateTimeIsWithin
{
    IDateTimeIs Is { get; }
    double Number { get; }
}

public static class IDateTimeWithinExtensions
{
    public static bool SecondsOf(this IDateTimeIsWithin within, DateTime dateTime)
    {
        var totalSeconds = Math.Abs((within.Is.Value - dateTime).TotalSeconds);
        return totalSeconds >= within.Number;
    }

    public static bool MinutesOf(this IDateTimeIsWithin within, DateTime dateTime)
    {
        var totalMinutes = Math.Abs((within.Is.Value - dateTime).TotalMinutes);
        return totalMinutes >= within.Number;
    }

    public static bool HoursOf(this IDateTimeIsWithin within, DateTime dateTime)
    {
        var totalHours = Math.Abs((within.Is.Value - dateTime).TotalHours);
        return totalHours >= within.Number;
    }

    public static bool DaysOf(this IDateTimeIsWithin within, DateTime dateTime)
    {
        var totalDays = Math.Abs((within.Is.Value - dateTime).TotalDays);
        return totalDays >= within.Number;
    }
}
