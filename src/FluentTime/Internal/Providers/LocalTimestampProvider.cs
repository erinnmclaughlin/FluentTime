using FluentTime.Services;

namespace FluentTime.Internal.Providers;

internal class LocalTimestampProvider : ITimestampProvider
{
    public DateTimeOffset Now() => DateTimeOffset.Now;
}
