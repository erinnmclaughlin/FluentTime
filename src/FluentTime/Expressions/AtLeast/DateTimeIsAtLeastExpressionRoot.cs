namespace FluentTime.Expressions.AtLeast;

internal record DateTimeIsAtLeastExpressionRoot(DateTime DateTime, double Magnitude) : DateTimeIsExpressionRoot<IDateTimeIsAtLeastExpression>
{
    protected override IDateTimeIsAtLeastExpression GetExpression(UnitOfTime unitOfTime)
    {
        var context = new DateTimeIsContext(DateTime, Magnitude, unitOfTime);
        return new DateTimeIsAtLeastExpression(context);
    }
}
