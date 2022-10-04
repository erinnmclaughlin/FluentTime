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

    public static IDateTimeIsAtLeastInitial AtLeast(this IDateTimeIs dateTimeIs, double number)
    {
        return new DateTimeIsDelclarationInitial(dateTimeIs.DateTime, number);
    }

    public static bool Before(this IDateTimeIs dateTimeIs, DateTime dateTime)
    {
        return dateTimeIs.DateTime < dateTime;
    }

    public static IDateTimeIsExactlyInitial Exactly(this IDateTimeIs dateTimeIs, double number)
    {
        return new DateTimeIsDelclarationInitial(dateTimeIs.DateTime, number);
    }

    public static IDateTimeIsWithinInitial Within(this IDateTimeIs dateTimeIs, double number)
    {
        return new DateTimeIsDelclarationInitial(dateTimeIs.DateTime, number);
    }
}
