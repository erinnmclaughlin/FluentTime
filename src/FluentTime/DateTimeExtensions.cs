using FluentTime.Internal;

namespace FluentTime;

public static class DateTimeExtensions
{
    public static IDateTimeIs Is(this DateTime dateTime) => new DateTimeIs(dateTime);
    public static bool Is(this DateTime dt1, DateTime dt2) => dt1.Equals(dt2);
}
