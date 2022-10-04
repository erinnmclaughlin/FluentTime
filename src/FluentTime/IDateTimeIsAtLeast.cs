using FluentTime.Internal;

namespace FluentTime;

public interface IDateTimeIsAtLeastInitial
{
    DateTime DateTime { get; }
    double Value { get; }
}

public static class IDateTimeIsAtLeastInitialExtensions
{
    public static IDateTimeIsAtLeast Seconds(this IDateTimeIsAtLeastInitial i)
        => new DateTimeIsDeclaration(i.DateTime, new(i.Value, UnitOfTime.Seconds));

    public static IDateTimeIsAtLeast Minutes(this IDateTimeIsAtLeastInitial i)
        => new DateTimeIsDeclaration(i.DateTime, new(i.Value, UnitOfTime.Minutes));

    public static IDateTimeIsAtLeast Hours(this IDateTimeIsAtLeastInitial i)
        => new DateTimeIsDeclaration(i.DateTime, new(i.Value, UnitOfTime.Hours));

    public static IDateTimeIsAtLeast Days(this IDateTimeIsAtLeastInitial i)
        => new DateTimeIsDeclaration(i.DateTime, new(i.Value, UnitOfTime.Days));
}

public interface IDateTimeIsAtLeast
{
    DateTime DateTime { get; }
    TimeMeasurement Value { get; }
}

public static class IDateTimeIsAtLeastExtensions
{
    public static bool After(this IDateTimeIsAtLeast atLeast, DateTime dateTime) => atLeast.Value.Units switch
    {
        UnitOfTime.Seconds => (atLeast.DateTime - dateTime).TotalSeconds,
        UnitOfTime.Minutes => (atLeast.DateTime - dateTime).TotalMinutes,
        UnitOfTime.Hours => (atLeast.DateTime - dateTime).TotalHours,
        UnitOfTime.Days => (atLeast.DateTime - dateTime).TotalDays,
        _ => throw new NotSupportedException()
    } >= atLeast.Value.Value;

    public static bool Before(this IDateTimeIsAtLeast atLeast, DateTime dateTime) => atLeast.Value.Units switch
    {
        UnitOfTime.Seconds => (dateTime - atLeast.DateTime).TotalSeconds,
        UnitOfTime.Minutes => (dateTime- atLeast.DateTime).TotalMinutes,
        UnitOfTime.Hours => (dateTime- atLeast.DateTime).TotalHours,
        UnitOfTime.Days => (dateTime - atLeast.DateTime).TotalDays,
        _ => throw new NotSupportedException()
    } <= atLeast.Value.Value;
}
