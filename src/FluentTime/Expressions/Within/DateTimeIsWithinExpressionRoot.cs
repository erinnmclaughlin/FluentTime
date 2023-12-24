using FluentTime.Expressions.AtLeast;

namespace FluentTime.Expressions.Within;

internal sealed record DateTimeIsWithinExpressionRoot(DateTime DateTime, double Value) : DateTimeIsExpressionRoot<IDateTimeIsWithinExpression>
{
    protected override IDateTimeIsWithinExpression GetExpression(UnitOfTime unitOfTime)
    {
        var context = new DateTimeIsContext(DateTime, Value, unitOfTime);
        return new DateTimeIsWithinExpression(context);
    }
}
