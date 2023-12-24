namespace FluentTime.Expressions.AtLeast;

internal abstract record DateTimeIsExpressionRoot<TExpression> : IDateTimeIsExpressionRoot<TExpression>
{
    public TExpression Seconds => GetExpression(UnitOfTime.Seconds);
    public TExpression Hours => GetExpression(UnitOfTime.Hours);
    public TExpression Minutes => GetExpression(UnitOfTime.Minutes);
    public TExpression Days => GetExpression(UnitOfTime.Days);

    protected abstract TExpression GetExpression(UnitOfTime unitOfTime);
}