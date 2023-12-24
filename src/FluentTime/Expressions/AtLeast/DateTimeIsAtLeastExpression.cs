namespace FluentTime.Expressions.AtLeast;

internal record DateTimeIsAtLeastExpression(DateTimeIsContext Context) : DateTimeIsExpression(Context), IDateTimeIsAtLeastExpression
{
    public bool After(DateTime other) => GetMagnitude(other) >= Context.Magnitude;
    public bool Before(DateTime other) => -1 * GetMagnitude(other) <= Context.Magnitude;
}
