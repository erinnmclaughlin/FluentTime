using FluentTime.Internal;

namespace FluentTime;

public static class DateTimeExtensions
{
    public static IDateTimeIs Is(this DateTime dateTime)
    {
        return new DateTimeIs(dateTime);
    }
}
