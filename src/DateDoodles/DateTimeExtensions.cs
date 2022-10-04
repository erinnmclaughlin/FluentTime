using DateDoodles.Internal;

namespace DateDoodles;

public static class DateTimeExtensions
{
    public static IDateTimeIs Is(this DateTime dateTime)
    {
        return new DateTimeIs(dateTime);
    }
}
