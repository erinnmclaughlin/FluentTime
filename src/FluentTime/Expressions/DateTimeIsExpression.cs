namespace FluentTime.Expressions;

internal abstract record DateTimeIsExpression(DateTimeIsContext Context)
{
    protected double GetMagnitude(DateTime other)
    {
        var timespan = Context.DateTime - other;
        return Context.Units switch
        {
            UnitOfTime.Seconds => timespan.TotalSeconds,
            UnitOfTime.Minutes => timespan.TotalMinutes,
            UnitOfTime.Hours => timespan.TotalHours,
            UnitOfTime.Days => timespan.TotalDays,
            _ => throw new NotImplementedException()
        };
    }
}