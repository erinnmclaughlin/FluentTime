using FluentAssertions;

namespace FluentTime.UnitTests;

public class DateTimeIsExactlyTests
{
    public static readonly DateTime ThePresent = DateTime.UtcNow;

    [Fact]
    public void SecondsAfter_ShouldReturnExpected()
    {
        var futureValue = ThePresent.AddSeconds(2.5);

        futureValue.IsExactly(2).Seconds.After(ThePresent).Should().BeFalse();
        futureValue.IsExactly(2.5).Seconds.After(ThePresent).Should().BeTrue();
        futureValue.IsExactly(3).Seconds.After(ThePresent).Should().BeFalse();
    }

    [Fact]
    public void SecondsBefore_ShouldReturnExpected()
    {
        var futureValue = ThePresent.AddSeconds(2.5);

        ThePresent.IsExactly(2).Seconds.Before(futureValue).Should().BeFalse();
        ThePresent.IsExactly(2.5).Seconds.Before(futureValue).Should().BeTrue();
        ThePresent.IsExactly(3).Seconds.Before(futureValue).Should().BeFalse();
    }

    [Fact]
    public void MinutesAfter_ShouldReturnExpected()
    {
        var futureValue = ThePresent.AddMinutes(2.5);

        futureValue.IsExactly(2).Minutes.After(ThePresent).Should().BeFalse();
        futureValue.IsExactly(2.5).Minutes.After(ThePresent).Should().BeTrue();
        futureValue.IsExactly(3).Minutes.After(ThePresent).Should().BeFalse();
    }

    [Fact]
    public void MinutesBefore_ShouldReturnExpected()
    {
        var futureValue = ThePresent.AddMinutes(2.5);

        ThePresent.IsExactly(2).Minutes.Before(futureValue).Should().BeFalse();
        ThePresent.IsExactly(2.5).Minutes.Before(futureValue).Should().BeTrue();
        ThePresent.IsExactly(3).Minutes.Before(futureValue).Should().BeFalse();
    }

    [Fact]
    public void HoursAfter_ShouldReturnExpected()
    {
        var futureValue = ThePresent.AddHours(2.5);

        futureValue.IsExactly(2).Hours.After(ThePresent).Should().BeFalse();
        futureValue.IsExactly(2.5).Hours.After(ThePresent).Should().BeTrue();
        futureValue.IsExactly(3).Hours.After(ThePresent).Should().BeFalse();
    }


    [Fact]
    public void HoursBefore_ShouldReturnExpected()
    {
        var futureValue = ThePresent.AddHours(2.5);

        ThePresent.IsExactly(2).Hours.Before(futureValue).Should().BeFalse();
        ThePresent.IsExactly(2.5).Hours .Before(futureValue).Should().BeTrue();
        ThePresent.IsExactly(3).Hours.Before(futureValue).Should().BeFalse();
    }


    [Fact]
    public void DaysAfter_ShouldReturnExpected()
    {
        var futureValue = ThePresent.AddDays(2.5);

        futureValue.IsExactly(2).Days.After(ThePresent).Should().BeFalse();
        futureValue.IsExactly(2.5).Days.After(ThePresent).Should().BeTrue();
        futureValue.IsExactly(3).Days.After(ThePresent).Should().BeFalse();
    }


    [Fact]
    public void DaysBefore_ShouldReturnExpected()
    {
        var futureValue = ThePresent.AddDays(2.5);

        ThePresent.IsExactly(2).Days.Before(futureValue).Should().BeFalse();
        ThePresent.IsExactly(2.5).Days.Before(futureValue).Should().BeTrue();
        ThePresent.IsExactly(3).Days.Before(futureValue).Should().BeFalse();
    }
}
