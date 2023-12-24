namespace FluentTime.Expressions;

public interface IDateTimeIsExpressionRoot<TExpression>
{
    public TExpression Seconds => GetExpression(UnitOfTime.Seconds);
    public TExpression Hours => GetExpression(UnitOfTime.Hours);
    public TExpression Minutes => GetExpression(UnitOfTime.Minutes);
    public TExpression Days => GetExpression(UnitOfTime.Days);

    internal TExpression GetExpression(UnitOfTime unitOfTime);
}
