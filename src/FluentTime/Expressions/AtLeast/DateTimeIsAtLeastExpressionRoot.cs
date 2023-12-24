namespace FluentTime.Expressions.AtLeast;

public record DateTimeIsAtLeastExpressionRoot(DateTime DateTime, double Magnitude) : DateTimeIsExpressionRootBase<DateTimeIsAtLeastExpression>
{
    protected override DateTimeIsAtLeastExpression GetExpression(UnitOfTime unitOfTime)
    {
        var context = new DateTimeIsContext(DateTime, Magnitude, unitOfTime);
        return new DateTimeIsAtLeastExpression(context);
    }
}
