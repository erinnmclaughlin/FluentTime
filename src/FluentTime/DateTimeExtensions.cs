using FluentTime.Expressions.AtLeast;
using FluentTime.Expressions.AtMost;
using FluentTime.Expressions.Exactly;
using FluentTime.Expressions.Within;

namespace FluentTime;

public static class DateTimeExtensions
{
    public static bool Is(this DateTime dt1, DateTime dt2) => dt1.Equals(dt2);
    public static bool IsInThePast(this DateTime dt) => Currently.It.IsAfter(dt);
    public static bool IsInTheFuture(this DateTime dt) => Currently.It.IsBefore(dt);

    public static bool IsAfter(this DateTime root, DateTime other)
    {
        return root > other;
    }

    public static bool IsOnOrAfter(this DateTime root, DateTime other)
    {
        return root >= other;
    }

    public static bool IsBefore(this DateTime root, DateTime other)
    {
        return root < other;
    }

    public static bool IsOnOrBefore(this DateTime root, DateTime other)
    {
        return root <= other;
    }

    public static DateTimeIsAtLeastExpressionRoot IsAtLeast(this DateTime root, double magnitude)
    {
        return new(root, magnitude);
    }

    public static DateTimeIsAtMostExpressionRoot IsAtMost(this DateTime root, double magnitude)
    {
        return new(root, magnitude);
    }

    public static DateTimeIsExactlyExpressionRoot IsExactly(this DateTime root, double magnitude)
    {
        return new(root, magnitude);
    }

    public static DateTimeIsWithinExpressionRoot IsWithin(this DateTime root, double magnitude)
    {
        return new(root, magnitude);
    }
}
