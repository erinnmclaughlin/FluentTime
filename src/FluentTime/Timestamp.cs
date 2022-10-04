namespace FluentTime;

public sealed record Date
{
	public DateOnly Value { get; }

	internal Date(DateOnly value)
	{
		Value = value;
	}

	internal static Date FromDateTime(DateTimeOffset dateTime) => new(DateOnly.FromDateTime(dateTime.DateTime));
}

public sealed record Time
{
	public TimeOnly Value { get; }

    internal Time(TimeOnly value)
	{
		Value = value;
	}

	internal static Time FromDateTime(DateTimeOffset dateTime) => new(TimeOnly.FromDateTime(dateTime.DateTime));
}

public sealed record Timestamp
{
    public DateTimeOffset Value { get; }

    internal Timestamp(DateTimeOffset value)
	{
		Value = value;
	}
}