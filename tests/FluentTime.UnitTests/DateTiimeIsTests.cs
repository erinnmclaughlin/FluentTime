using FluentAssertions;

namespace FluentTime.UnitTests;

public class DateTiimeIsTests
{
    public static readonly DateTime ThePresent = DateTime.UtcNow;

    [Fact]
    public void After_ReturnsExpected()
    {
        var thePast = ThePresent.AddSeconds(2.5);

        ThePresent.IsAfter(thePast).Should().BeFalse();
        ThePresent.IsAfter(ThePresent).Should().BeFalse();
        thePast.IsAfter(ThePresent).Should().BeTrue();
    }

    [Fact]
    public void Before_ReturnsExpected()
    {
        var futureValue = ThePresent.AddSeconds(2.5);

        ThePresent.IsBefore(futureValue).Should().BeTrue();
        ThePresent.IsBefore(ThePresent).Should().BeFalse();
        futureValue.IsBefore(ThePresent).Should().BeFalse();
    }

    [Fact]
    public void Is_ReturnsExpected()
    {
        var theFuture = ThePresent.AddSeconds(2.5);

        ThePresent.Is(2.5).Seconds.Before(theFuture).Should().BeTrue();
        ThePresent.Is(2).Seconds.Before(theFuture).Should().BeFalse();
        ThePresent.Is(3).Seconds.Before(theFuture).Should().BeFalse();
    }
}
