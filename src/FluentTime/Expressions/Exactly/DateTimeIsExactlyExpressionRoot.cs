namespace FluentTime.Expressions.Exactly;

public record DateTimeIsExactlyExpressionRoot(DateTime DateTime, double Value) : DateTimeIsExpressionRootBase<DateTimeIsExactlyExpression>
{
    protected override DateTimeIsExactlyExpression GetExpression(UnitOfTime unitOfTime)
    {
        var context = new DateTimeIsContext(DateTime, Value, unitOfTime);
        return new DateTimeIsExactlyExpression(context);
    }
}
