namespace FluentTime.Expressions.Within;

internal sealed record DateTimeIsWithinExpression(DateTimeIsContext Context) : DateTimeIsExpression(Context), IDateTimeIsWithinExpression
{
    public bool Of(DateTime other)
    {
        var timespan = Context.DateTime - other;
        return Math.Abs(GetMagnitude(timespan)) <= Context.Magnitude;
    }
}