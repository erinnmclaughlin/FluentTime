namespace FluentTime.Services;

public interface ITimestampProvider
{
    DateTimeOffset Now();
}
