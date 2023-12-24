namespace FluentTime.Expressions.Exactly;

internal record DateTimeIsExactlyExpression(DateTimeIsContext Context) : DateTimeIsExpression(Context), IDateTimeIsExactlyExpression
{

    public bool After(DateTime other) => GetMagnitude(other) == Context.Magnitude;
    public bool Before(DateTime other) => -1 * GetMagnitude(other) == Context.Magnitude;
}