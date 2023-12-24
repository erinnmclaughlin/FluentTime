using FluentTime.Expressions.AtLeast;

namespace FluentTime.Expressions.Within;

internal sealed record DateTimeIsWithinExpressionRoot(DateTime DateTime, double Value) : DateTimeIsExpressionRoot<DateTimeIsWithinExpression>
{
    protected override DateTimeIsWithinExpression GetExpression(UnitOfTime unitOfTime)
    {
        var context = new DateTimeIsContext(DateTime, Value, unitOfTime);
        return new DateTimeIsWithinExpression(context);
    }
}
