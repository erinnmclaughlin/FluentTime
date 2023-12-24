using FluentTime.Expressions;

namespace FluentTime;

public abstract record DateTimeIsExpressionRootBase<TExpression> : IDateTimeIsExpressionRoot<TExpression>
{
    public TExpression Seconds => GetExpression(UnitOfTime.Seconds);
    public TExpression Hours => GetExpression(UnitOfTime.Hours);
    public TExpression Minutes => GetExpression(UnitOfTime.Minutes);
    public TExpression Days => GetExpression(UnitOfTime.Days);

    protected abstract TExpression GetExpression(UnitOfTime unitOfTime);

    TExpression IDateTimeIsExpressionRoot<TExpression>.GetExpression(UnitOfTime unitOfTime)
    {
        return GetExpression(unitOfTime);
    }
}
