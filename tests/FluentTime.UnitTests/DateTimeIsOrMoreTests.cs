using FluentAssertions;

namespace FluentTime.UnitTests;

public class DateTimeIsOrMoreTests
{
    public static readonly DateTime ThePresent = DateTime.UtcNow;

    [Fact]
    public void SecondsOrMoreAfter_ShouldReturnExpected()
    {
        var theFuture = ThePresent.AddSeconds(2.5);

        theFuture.Is(2).OrMore.Seconds.After(ThePresent).Should().BeTrue();
        theFuture.Is(2.5).OrMore.Seconds.After(ThePresent).Should().BeTrue();
        theFuture.Is(3).OrMore.Seconds.After(ThePresent).Should().BeFalse();
    }

    [Fact]
    public void SecondsOrMoreBefore_ShouldReturnExpected()
    {
        var theFuture = ThePresent.AddSeconds(2.5);

        theFuture.Is(2).OrMore.Seconds.Before(ThePresent).Should().BeFalse();
        theFuture.Is(2.5).OrMore.Seconds.Before(ThePresent).Should().BeFalse();
        theFuture.Is(3).OrMore.Seconds.Before(ThePresent).Should().BeFalse();

        ThePresent.Is(2).OrMore.Seconds.Before(theFuture).Should().BeTrue();
        ThePresent.Is(2.5).OrMore.Seconds.Before(theFuture).Should().BeTrue();
        ThePresent.Is(3).OrMore.Seconds.Before(theFuture).Should().BeFalse();
    }
}
