namespace FluentTime.Expressions;

internal abstract record DateTimeIsExpression(DateTimeIsContext Context)
{
    protected double GetMagnitude(TimeSpan timespan) => Context.Units switch
    {
        UnitOfTime.Seconds => timespan.TotalSeconds,
        UnitOfTime.Minutes => timespan.TotalMinutes,
        UnitOfTime.Hours => timespan.TotalHours,
        UnitOfTime.Days => timespan.TotalDays,
        _ => throw new NotImplementedException()
    };
}