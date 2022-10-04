using FluentTime.Services;

namespace FluentTime.Internal.Providers;

internal sealed class UtcTimestampProvider : ITimestampProvider
{
    public DateTimeOffset Now() => DateTimeOffset.UtcNow;
}
