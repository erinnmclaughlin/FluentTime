namespace FluentTime.Expressions.Within;

internal sealed record DateTimeIsWithinExpression(DateTimeIsContext Context) : DateTimeIsExpression(Context), IDateTimeIsWithinExpression
{
    public bool Of(DateTime other)
    {
        return Math.Abs(GetMagnitude(other)) <= Context.Magnitude;
    }
}