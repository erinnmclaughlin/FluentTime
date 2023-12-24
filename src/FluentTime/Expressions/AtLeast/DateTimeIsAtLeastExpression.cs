namespace FluentTime.Expressions.AtLeast;

internal record DateTimeIsAtLeastExpression(DateTimeIsContext Context) : DateTimeIsExpression(Context), IDateTimeIsAtLeastExpression
{
    public bool After(DateTime other) => GetMagnitude(Context.DateTime - other) >= Context.Magnitude;
    public bool Before(DateTime other) => GetMagnitude(other - Context.DateTime) <= Context.Magnitude;
}
