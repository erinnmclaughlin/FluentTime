using FluentAssertions;

namespace FluentTime.UnitTests;

public class DateTimeIsAtMostTests
{
    public static readonly DateTime ThePresent = DateTime.UtcNow;

    [Fact]
    public void SecondsAfter_ShouldReturnExpected()
    {
        var futureValue = ThePresent.AddSeconds(2.5);

        futureValue.IsAtMost(2).Seconds.After(ThePresent).Should().BeFalse();
        futureValue.IsAtMost(2.5).Seconds.After(ThePresent).Should().BeTrue();
        futureValue.IsAtMost(3).Seconds.After(ThePresent).Should().BeTrue();
    }

    [Fact]
    public void SecondsBefore_ShouldReturnExpected()
    {
        var futureValue = ThePresent.AddSeconds(2.5);

        ThePresent.IsAtMost(2).Seconds.Before(futureValue).Should().BeTrue();
        ThePresent.IsAtMost(2.5).Seconds.Before(futureValue).Should().BeTrue();
        ThePresent.IsAtMost(3).Seconds.Before(futureValue).Should().BeFalse();
    }

    [Fact]
    public void MinutesAfter_ShouldReturnExpected()
    {
        var futureValue = ThePresent.AddMinutes(2.5);

        futureValue.IsAtMost(2).Minutes.After(ThePresent).Should().BeFalse();
        futureValue.IsAtMost(2.5).Minutes.After(ThePresent).Should().BeTrue();
        futureValue.IsAtMost(3).Minutes.After(ThePresent).Should().BeTrue();
    }

    [Fact]
    public void MinutesBefore_ShouldReturnExpected()
    {
        var futureValue = ThePresent.AddMinutes(2.5);

        ThePresent.IsAtMost(2).Minutes.Before(futureValue).Should().BeTrue();
        ThePresent.IsAtMost(2.5).Minutes.Before(futureValue).Should().BeTrue();
        ThePresent.IsAtMost(3).Minutes.Before(futureValue).Should().BeFalse();
    }

    [Fact]
    public void HoursAfter_ShouldReturnExpected()
    {
        var futureValue = ThePresent.AddHours(2.5);

        futureValue.IsAtMost(2).Hours.After(ThePresent).Should().BeFalse();
        futureValue.IsAtMost(2.5).Hours.After(ThePresent).Should().BeTrue();
        futureValue.IsAtMost(3).Hours.After(ThePresent).Should().BeTrue();
    }


    [Fact]
    public void HoursBefore_ShouldReturnExpected()
    {
        var futureValue = ThePresent.AddHours(2.5);

        ThePresent.IsAtMost(2).Hours.Before(futureValue).Should().BeTrue();
        ThePresent.IsAtMost(2.5).Hours.Before(futureValue).Should().BeTrue();
        ThePresent.IsAtMost(3).Hours.Before(futureValue).Should().BeFalse();
    }


    [Fact]
    public void DaysAfter_ShouldReturnExpected()
    {
        var futureValue = ThePresent.AddDays(2.5);

        futureValue.IsAtMost(2).Days.After(ThePresent).Should().BeFalse();
        futureValue.IsAtMost(2.5).Days.After(ThePresent).Should().BeTrue();
        futureValue.IsAtMost(3).Days.After(ThePresent).Should().BeTrue();
    }


    [Fact]
    public void DaysBefore_ShouldReturnExpected()
    {
        var futureValue = ThePresent.AddDays(2.5);

        ThePresent.IsAtMost(2).Days.Before(futureValue).Should().BeTrue();
        ThePresent.IsAtMost(2.5).Days.Before(futureValue).Should().BeTrue();
        ThePresent.IsAtMost(3).Days.Before(futureValue).Should().BeFalse();
    }

    [Fact]
    public void DaysAway_ShouldReturnExpected()
    {
        var theFuture = DateTime.Now.AddDays(10);

        theFuture.IsAtMost(5).Days.Away().Should().BeFalse();
    }
}
