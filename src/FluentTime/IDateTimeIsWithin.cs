namespace FluentTime;

public interface IDateTimeIsWithin
{
    DateTime DateTime { get; }
    double Value { get; }
}

public static class IDateTimeWithinExtensions
{
    public static bool SecondsOf(this IDateTimeIsWithin within, DateTime dateTime)
    {
        var totalSeconds = Math.Abs((within.DateTime - dateTime).TotalSeconds);
        return totalSeconds <= within.Value;
    }

    public static bool MinutesOf(this IDateTimeIsWithin within, DateTime dateTime)
    {
        var totalMinutes = Math.Abs((within.DateTime - dateTime).TotalMinutes);
        return totalMinutes <= within.Value;
    }

    public static bool HoursOf(this IDateTimeIsWithin within, DateTime dateTime)
    {
        var totalHours = Math.Abs((within.DateTime - dateTime).TotalHours);
        return totalHours <= within.Value;
    }

    public static bool DaysOf(this IDateTimeIsWithin within, DateTime dateTime)
    {
        var totalDays = Math.Abs((within.DateTime - dateTime).TotalDays);
        return totalDays <= within.Value;
    }
}
