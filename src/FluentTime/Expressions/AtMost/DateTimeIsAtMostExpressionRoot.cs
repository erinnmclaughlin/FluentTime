using FluentTime.Expressions.AtLeast;

namespace FluentTime.Expressions.AtMost;
public record DateTimeIsAtMostExpressionRoot(DateTime DateTime, double Magnitude) : DateTimeIsExpressionRoot<DateTimeIsAtMostExpression>
{
    protected override DateTimeIsAtMostExpression GetExpression(UnitOfTime unitOfTime)
    {
        var context = new DateTimeIsContext(DateTime, Magnitude, unitOfTime);
        return new DateTimeIsAtMostExpression(context);
    }
}
