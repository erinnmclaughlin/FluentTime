namespace FluentTime.Expressions.Within;

public sealed record DateTimeIsWithinExpression(DateTimeIsContext Context) : DateTimeIsExpression(Context)
{
    public bool Of(DateTime other)
    {
        return Math.Abs(GetMagnitude(other)) <= Context.Magnitude;
    }

    public static implicit operator bool(DateTimeIsWithinExpression expression) => expression.Of(DateTime.Now);
}