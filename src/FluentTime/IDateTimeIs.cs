using FluentTime.Internal;

namespace FluentTime;

public interface IDateTimeIs
{
    DateTime DateTime { get; }
}

public static class IDateTimeIsExtensions
{
    public static bool After(this IDateTimeIs dateTimeIs, DateTime dateTime)
    {
        return dateTimeIs.DateTime > dateTime;
    }

    public static IDateTimeIsAtLeast AtLeast(this IDateTimeIs dateTimeIs, double number)
    {
        return new DateTimeIsDelclaration(dateTimeIs.DateTime, number);
    }

    public static bool Before(this IDateTimeIs dateTimeIs, DateTime dateTime)
    {
        return dateTimeIs.DateTime < dateTime;
    }

    public static IDateTimeIsWithin Within(this IDateTimeIs dateTimeIs, double number)
    {
        return new DateTimeIsDelclaration(dateTimeIs.DateTime, number);
    }
}
