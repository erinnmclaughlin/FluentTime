using FluentTime.Internal;

namespace FluentTime;

public interface IDateTimeIs
{
    DateTime Value { get; }
}

public static class IDateTimeIsExtensions
{
    public static IDateTimeIsAtLeast AtLeast(this IDateTimeIs dateTimeIs, double number)
    {
        return new DateTimeIsAtLeast(dateTimeIs, number);
    }

    public static IDateTimeIsWithin Within(this IDateTimeIs dateTimeIs, double number)
    {
        return new DateTimeIsWithin(dateTimeIs, number);
    }
}
