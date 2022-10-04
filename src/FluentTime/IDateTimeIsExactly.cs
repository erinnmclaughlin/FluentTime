using FluentTime.Internal;

namespace FluentTime;

public interface IDateTimeIsExactlyInitial
{
    DateTime DateTime { get; }
    double Value { get; }
}

public static class IDateTimeIsExactlyInitialExtensions
{
    public static IDateTimeIsExactly Seconds(this IDateTimeIsExactlyInitial i)
        => new DateTimeIsDeclaration(i.DateTime, new(i.Value, UnitOfTime.Seconds));

    public static IDateTimeIsExactly Minutes(this IDateTimeIsExactlyInitial i)
        => new DateTimeIsDeclaration(i.DateTime, new(i.Value, UnitOfTime.Minutes));

    public static IDateTimeIsExactly Hours(this IDateTimeIsExactlyInitial i)
        => new DateTimeIsDeclaration(i.DateTime, new(i.Value, UnitOfTime.Hours));

    public static IDateTimeIsExactly Days(this IDateTimeIsExactlyInitial i)
        => new DateTimeIsDeclaration(i.DateTime, new(i.Value, UnitOfTime.Days));
}

public interface IDateTimeIsExactly
{
    DateTime DateTime { get; }
    TimeMeasurement Value { get; }
}

public static class IDateTimeIsExactlyExtensions
{
    public static bool After(this IDateTimeIsExactly exactly, DateTime dateTime) => exactly.Value.Units switch
    {
        UnitOfTime.Seconds => (exactly.DateTime - dateTime).TotalSeconds,
        UnitOfTime.Minutes => (exactly.DateTime - dateTime).TotalMinutes,
        UnitOfTime.Hours => (exactly.DateTime - dateTime).TotalHours,
        UnitOfTime.Days => (exactly.DateTime - dateTime).TotalDays,
        _ => throw new NotSupportedException()
    } == exactly.Value.Value;

    public static bool Before(this IDateTimeIsExactly exactly, DateTime dateTime) => exactly.Value.Units switch
    {
        UnitOfTime.Seconds => (dateTime - exactly.DateTime).TotalSeconds,
        UnitOfTime.Minutes => (dateTime - exactly.DateTime).TotalMinutes,
        UnitOfTime.Hours => (dateTime - exactly.DateTime).TotalHours,
        UnitOfTime.Days => (dateTime - exactly.DateTime).TotalDays,
        _ => throw new NotSupportedException()
    } == exactly.Value.Value;
}