using FluentTime.Expressions;

namespace FluentTime.Expressions.OrMore;

public record DateTimeIsOrMoreExpression(DateTimeIsContext Context) : DateTimeIsExpression(Context)
{
    public bool After(DateTime other) => GetMagnitude(other) >= Context.Magnitude;
    public bool Before(DateTime other) => -1 * GetMagnitude(other) >= Context.Magnitude;
}