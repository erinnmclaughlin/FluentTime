using FluentTime.Expressions.AtLeast;

namespace FluentTime.Expressions.Exactly;

internal record DateTimeIsExactlyExpressionRoot(DateTime DateTime, double Value) : DateTimeIsExpressionRoot<IDateTimeIsExactlyExpression>
{
    protected override IDateTimeIsExactlyExpression GetExpression(UnitOfTime unitOfTime)
    {
        var context = new DateTimeIsContext(DateTime, Value, unitOfTime);
        return new DateTimeIsExactlyExpression(context);
    }
}
