using FluentAssertions;

namespace FluentTime.UnitTests;

public class DateTimeIsWithinTests
{
    public static readonly DateTime ThePresent = DateTime.UtcNow;

    [Fact]
    public void SecondsOf_ReturnsExpected()
    {
        var futureValue = ThePresent.AddSeconds(2.5);
        var pastValue = ThePresent.AddSeconds(-2.5);

        ThePresent.IsWithin(1).Seconds.Of(futureValue).Should().BeFalse();
        ThePresent.IsWithin(2.5).Seconds.Of(futureValue).Should().BeTrue();
        ThePresent.IsWithin(3).Seconds.Of(futureValue).Should().BeTrue();
        ThePresent.IsWithin(3).Seconds.Of(pastValue).Should().BeTrue();
        ThePresent.IsWithin(2.5).Seconds.Of(pastValue).Should().BeTrue();
        ThePresent.IsWithin(1).Seconds.Of(pastValue).Should().BeFalse();
    }

    [Fact]
    public void MinutesOf_ReturnsExpected()
    {
        var futureValue = ThePresent.AddMinutes(2.5);
        var pastValue = ThePresent.AddMinutes(-2.5);

        ThePresent.IsWithin(1).Minutes.Of(futureValue).Should().BeFalse();
        ThePresent.IsWithin(2.5).Minutes.Of(futureValue).Should().BeTrue();
        ThePresent.IsWithin(3).Minutes.Of(futureValue).Should().BeTrue();
        ThePresent.IsWithin(3).Minutes.Of(pastValue).Should().BeTrue();
        ThePresent.IsWithin(2.5).Minutes.Of(pastValue).Should().BeTrue();
        ThePresent.IsWithin(1).Minutes.Of(pastValue).Should().BeFalse();
    }

    [Fact]
    public void HoursOf_ReturnsExpected()
    {
        var futureValue = ThePresent.AddHours(2.5);
        var pastValue = ThePresent.AddHours(-2.5);

        ThePresent.IsWithin(1).Hours.Of(futureValue).Should().BeFalse();
        ThePresent.IsWithin(2.5).Hours.Of(futureValue).Should().BeTrue();
        ThePresent.IsWithin(3).Hours.Of(futureValue).Should().BeTrue();
        ThePresent.IsWithin(3).Hours.Of(pastValue).Should().BeTrue();
        ThePresent.IsWithin(2.5).Hours.Of(pastValue).Should().BeTrue();
        ThePresent.IsWithin(1).Hours.Of(pastValue).Should().BeFalse();
    }


    [Fact]
    public void DaysOf_ReturnsExpected()
    {
        var futureValue = ThePresent.AddDays(2.5);
        var pastValue = ThePresent.AddDays(-2.5);

        ThePresent.IsWithin(1).Days.Of(futureValue).Should().BeFalse();
        ThePresent.IsWithin(2.5).Days.Of(futureValue).Should().BeTrue();
        ThePresent.IsWithin(3).Days.Of(futureValue).Should().BeTrue();
        ThePresent.IsWithin(3).Days.Of(pastValue).Should().BeTrue();
        ThePresent.IsWithin(2.5).Days.Of(pastValue).Should().BeTrue();
        ThePresent.IsWithin(1).Days.Of(pastValue).Should().BeFalse();
    }
}
