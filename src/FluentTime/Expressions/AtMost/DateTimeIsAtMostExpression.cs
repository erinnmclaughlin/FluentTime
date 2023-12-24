namespace FluentTime.Expressions.AtMost;

public record DateTimeIsAtMostExpression(DateTimeIsContext Context) : DateTimeIsExpression(Context)
{
    public bool After(DateTime other) => GetMagnitude(other) <= Context.Magnitude;
    public bool Before(DateTime other) => -1 * GetMagnitude(other) >= Context.Magnitude;
    public bool Away() => After(DateTime.Now);
}
