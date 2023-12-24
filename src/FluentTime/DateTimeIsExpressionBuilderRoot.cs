using FluentTime.Expressions;
using FluentTime.Expressions.Exactly;
using FluentTime.Expressions.OrMore;

namespace FluentTime;

public record DateTimeIsExpressionBuilderRoot(DateTime DateTime, double Magnitude) : DateTimeIsExpressionRootBase<DateTimeIsExactlyExpression>
{
    public DateTimeIsOrMoreExpresionRoot OrMore => new(DateTime, Magnitude);

    protected override DateTimeIsExactlyExpression GetExpression(UnitOfTime unitOfTime)
    {
        var context = new DateTimeIsContext(DateTime, Magnitude, unitOfTime);
        return new DateTimeIsExactlyExpression(context);
    }
}
