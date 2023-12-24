namespace FluentTime;

public interface IDateTimeIsExpressionRoot<TExpression>
{
    TExpression Seconds { get; }
    TExpression Hours { get; }
    TExpression Minutes { get; }
    TExpression Days { get; }
}
