namespace FluentTime.Services;

public interface ITimestampEvaluator
{
	public TimeSpan GetTimeSpan(DateTimeOffset dateTime);
}

public sealed class TimestampEvaluator
{
    private readonly ITimestampProvider _provider;

	public TimestampEvaluator(ITimestampProvider provider)
	{
		_provider = provider;
	}

	public TimeSpan GetTimeSpan(DateTimeOffset dateTime)
	{
		return (dateTime - _provider.Now());
	}
}

public static class ITimestampEvaluatorExtensions
{
    public static double GetSecondsUntil(this ITimestampEvaluator e, DateTimeOffset dateTimeOffset)
	{
		return e.GetTimeSpan(dateTimeOffset).TotalSeconds;
    }

	public static double GetMinutesUntil(this ITimestampEvaluator e, DateTimeOffset dateTimeOffset)
    {
		return e.GetTimeSpan(dateTimeOffset).TotalMinutes;
    }

	public static double GetHoursUntil(this ITimestampEvaluator e, DateTimeOffset dateTimeOffset)
	{
		return e.GetTimeSpan(dateTimeOffset).TotalHours;
	}

	public static double GetDaysUntil(this ITimestampEvaluator e, DateTimeOffset dateTimeOffset)
	{
		return e.GetTimeSpan(dateTimeOffset).TotalDays;
	}

	public static bool IsInThePast(this ITimestampEvaluator e, DateTimeOffset dateTimeOffset)
	{
		return e.GetSecondsUntil(dateTimeOffset) < 0;
	}

	public static bool IsInTheFuture(this ITimestampEvaluator e, DateTimeOffset dateTimeOffset)
	{
		return e.GetSecondsUntil(dateTimeOffset) > 0;
	}
}