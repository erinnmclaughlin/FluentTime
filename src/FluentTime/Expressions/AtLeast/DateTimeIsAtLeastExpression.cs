namespace FluentTime.Expressions.AtLeast;

public record DateTimeIsAtLeastExpression(DateTimeIsContext Context) : DateTimeIsExpression(Context)
{
    public bool After(DateTime other) => GetMagnitude(other) >= Context.Magnitude;
    public bool Before(DateTime other) => -1 * GetMagnitude(other) <= Context.Magnitude;
    public bool Away() => After(DateTime.Now);
}
