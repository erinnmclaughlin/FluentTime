namespace FluentTime.Expressions.Exactly;

internal record DateTimeIsExactlyExpression(DateTimeIsContext Context) : DateTimeIsExpression(Context), IDateTimeIsExactlyExpression
{

    public bool After(DateTime other) => GetMagnitude(Context.DateTime - other) == Context.Magnitude;
    public bool Before(DateTime other) => GetMagnitude(other - Context.DateTime) == Context.Magnitude;
}