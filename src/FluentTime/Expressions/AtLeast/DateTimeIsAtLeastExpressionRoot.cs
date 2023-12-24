namespace FluentTime.Expressions.AtLeast;

internal record DateTimeIsAtLeastExpressionRoot(DateTime DateTime, double Magnitude) : DateTimeIsExpressionRoot<DateTimeIsAtLeastExpression>
{
    protected override DateTimeIsAtLeastExpression GetExpression(UnitOfTime unitOfTime)
    {
        var context = new DateTimeIsContext(DateTime, Magnitude, unitOfTime);
        return new DateTimeIsAtLeastExpression(context);
    }
}
