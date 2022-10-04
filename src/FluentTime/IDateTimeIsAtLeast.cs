namespace FluentTime;

public interface IDateTimeIsAtLeast
{
    DateTime DateTime { get; }
    double Value { get; }
}

public static class IDateTimeIsAtLeastExtensions
{
    public static bool SecondsAfter(this IDateTimeIsAtLeast atLeast, DateTime dateTime) => atLeast.TotalSeconds(dateTime) >= atLeast.Value;
    public static bool SecondsBefore(this IDateTimeIsAtLeast atLeast, DateTime dateTime) => (-1.0 * atLeast.TotalSeconds(dateTime)) <= atLeast.Value;
    private static double TotalSeconds(this IDateTimeIsAtLeast atLeast, DateTime dateTime) => (atLeast.DateTime - dateTime).TotalSeconds;

    public static bool MinutesAfter(this IDateTimeIsAtLeast atLeast, DateTime dateTime) => atLeast.TotalMinutes(dateTime) >= atLeast.Value;
    public static bool MinutesBefore(this IDateTimeIsAtLeast atLeast, DateTime dateTime) => (-1.0 * atLeast.TotalMinutes(dateTime)) <= atLeast.Value;
    private static double TotalMinutes(this IDateTimeIsAtLeast atLeast, DateTime dateTime) => (atLeast.DateTime - dateTime).TotalMinutes;

    public static bool HoursAfter(this IDateTimeIsAtLeast atLeast, DateTime dateTime) => atLeast.TotalHours(dateTime) >= atLeast.Value;
    public static bool HoursBefore(this IDateTimeIsAtLeast atLeast, DateTime dateTime) => (-1.0 * atLeast.TotalHours(dateTime)) <= atLeast.Value;
    private static double TotalHours(this IDateTimeIsAtLeast atLeast, DateTime dateTime) => (atLeast.DateTime - dateTime).TotalHours;

    public static bool DaysAfter(this IDateTimeIsAtLeast atLeast, DateTime dateTime) => atLeast.TotalDays(dateTime) >= atLeast.Value;
    public static bool DaysBefore(this IDateTimeIsAtLeast atLeast, DateTime dateTime) => (-1.0 * atLeast.TotalDays(dateTime)) <= atLeast.Value;
    private static double TotalDays(this IDateTimeIsAtLeast atLeast, DateTime dateTime) => (atLeast.DateTime - dateTime).TotalDays;
}
