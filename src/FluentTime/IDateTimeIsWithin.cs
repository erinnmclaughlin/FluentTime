using FluentTime.Internal;

namespace FluentTime;

public interface IDateTimeIsWithinInitial
{
    DateTime DateTime { get; }
    double Value { get; }
}

public static class IDateTimeIsWithinInitialExtensions
{
    public static IDateTimeIsWithin Seconds(this IDateTimeIsWithinInitial i)
    => new DateTimeIsDeclaration(i.DateTime, new(i.Value, UnitOfTime.Seconds));

    public static IDateTimeIsWithin Minutes(this IDateTimeIsWithinInitial i)
        => new DateTimeIsDeclaration(i.DateTime, new(i.Value, UnitOfTime.Minutes));

    public static IDateTimeIsWithin Hours(this IDateTimeIsWithinInitial i)
        => new DateTimeIsDeclaration(i.DateTime, new(i.Value, UnitOfTime.Hours));

    public static IDateTimeIsWithin Days(this IDateTimeIsWithinInitial i)
        => new DateTimeIsDeclaration(i.DateTime, new(i.Value, UnitOfTime.Days));
}

public interface IDateTimeIsWithin
{
    DateTime DateTime { get; }
    TimeMeasurement Value { get; }
}

public static class IDateTimeWithinExtensions
{
    public static bool Of(this IDateTimeIsWithin within, DateTime dateTime) => Math.Abs(within.Value.Units switch
    {
        UnitOfTime.Seconds => (within.DateTime - dateTime).TotalSeconds,
        UnitOfTime.Minutes => (within.DateTime - dateTime).TotalMinutes,
        UnitOfTime.Hours => (within.DateTime - dateTime).TotalHours,
        UnitOfTime.Days => (within.DateTime - dateTime).TotalDays,
        _ => throw new NotSupportedException()
    }) <= within.Value.Value;
}
