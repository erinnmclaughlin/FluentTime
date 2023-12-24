namespace FluentTime.Expressions.Within;

public sealed record DateTimeIsWithinExpressionRoot(DateTime DateTime, double Value) : DateTimeIsExpressionRootBase<DateTimeIsWithinExpression>
{
    protected override DateTimeIsWithinExpression GetExpression(UnitOfTime unitOfTime)
    {
        var context = new DateTimeIsContext(DateTime, Value, unitOfTime);
        return new DateTimeIsWithinExpression(context);
    }
}
