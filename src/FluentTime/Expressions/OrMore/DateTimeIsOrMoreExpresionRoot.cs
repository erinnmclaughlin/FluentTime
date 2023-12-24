namespace FluentTime.Expressions.OrMore;

public record DateTimeIsOrMoreExpresionRoot(DateTime DateTime, double Magnitude) : DateTimeIsExpressionRootBase<DateTimeIsOrMoreExpression>
{
    protected override DateTimeIsOrMoreExpression GetExpression(UnitOfTime unitOfTime)
    {
        var context = new DateTimeIsContext(DateTime, Magnitude, unitOfTime);
        return new DateTimeIsOrMoreExpression(context);
    }
}
