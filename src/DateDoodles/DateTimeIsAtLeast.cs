namespace DateDoodles;

public interface IDateTimeIsAtLeast
{
    IDateTimeIs Is { get; }
    double Number { get; }
}

public static class IDateTimeIsAtLeastExtensions
{
    public static bool SecondsAfter(this IDateTimeIsAtLeast atLeast, DateTime dateTime) => atLeast.TotalSeconds(dateTime) >= atLeast.Number;
    public static bool SecondsBefore(this IDateTimeIsAtLeast atLeast, DateTime dateTime) => (-1.0 * atLeast.TotalSeconds(dateTime)) <= atLeast.Number;
    private static double TotalSeconds(this IDateTimeIsAtLeast atLeast, DateTime dateTime) => (atLeast.Is.Value - dateTime).TotalSeconds;

    public static bool MinutesAfter(this IDateTimeIsAtLeast atLeast, DateTime dateTime) => atLeast.TotalMinutes(dateTime) >= atLeast.Number;
    public static bool MinutesBefore(this IDateTimeIsAtLeast atLeast, DateTime dateTime) => (-1.0 * atLeast.TotalMinutes(dateTime)) <= atLeast.Number;
    private static double TotalMinutes(this IDateTimeIsAtLeast atLeast, DateTime dateTime) => (atLeast.Is.Value - dateTime).TotalMinutes;

    public static bool HoursAfter(this IDateTimeIsAtLeast atLeast, DateTime dateTime) => atLeast.TotalHours(dateTime) >= atLeast.Number;
    public static bool HoursBefore(this IDateTimeIsAtLeast atLeast, DateTime dateTime) => (-1.0 * atLeast.TotalHours(dateTime)) <= atLeast.Number;
    private static double TotalHours(this IDateTimeIsAtLeast atLeast, DateTime dateTime) => (atLeast.Is.Value - dateTime).TotalHours;

    public static bool DaysAfter(this IDateTimeIsAtLeast atLeast, DateTime dateTime) => atLeast.TotalDays(dateTime) >= atLeast.Number;
    public static bool DaysBefore(this IDateTimeIsAtLeast atLeast, DateTime dateTime) => (-1.0 * atLeast.TotalDays(dateTime)) <= atLeast.Number;
    private static double TotalDays(this IDateTimeIsAtLeast atLeast, DateTime dateTime) => (atLeast.Is.Value - dateTime).TotalDays;
}
