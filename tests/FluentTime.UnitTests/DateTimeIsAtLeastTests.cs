using FluentAssertions;

namespace FluentTime.UnitTests;

public class DateTimeIsAtLeastTests
{
    public static readonly DateTime Now = DateTime.UtcNow;

    [Fact]
    public void SecondsAfter_ShouldReturnExpected()
    {
        var futureValue = Now.AddSeconds(2.5);

        futureValue.Is().AtLeast(2).Seconds().After(Now).Should().BeTrue();
        futureValue.Is().AtLeast(2.5).Seconds().After(Now).Should().BeTrue();
        futureValue.Is().AtLeast(3).Seconds().After(Now).Should().BeFalse();
    }

    [Fact]
    public void SecondsBefore_ShouldReturnExpected()
    {
        var futureValue = Now.AddSeconds(2.5);

        Now.Is().AtLeast(2).Seconds().Before(futureValue).Should().BeFalse();
        Now.Is().AtLeast(2.5).Seconds().Before(futureValue).Should().BeTrue();
        Now.Is().AtLeast(3).Seconds().Before(futureValue).Should().BeTrue();
    }

    [Fact]
    public void MinutesAfter_ShouldReturnExpected()
    {
        var futureValue = Now.AddMinutes(2.5);

        futureValue.Is().AtLeast(2).Minutes().After(Now).Should().BeTrue();
        futureValue.Is().AtLeast(2.5).Minutes().After(Now).Should().BeTrue();
        futureValue.Is().AtLeast(3).Minutes().After(Now).Should().BeFalse();
    }

    [Fact]
    public void MinutesBefore_ShouldReturnExpected()
    {
        var futureValue = Now.AddMinutes(2.5);

        Now.Is().AtLeast(2).Minutes().Before(futureValue).Should().BeFalse();
        Now.Is().AtLeast(2.5).Minutes().Before(futureValue).Should().BeTrue();
        Now.Is().AtLeast(3).Minutes().Before(futureValue).Should().BeTrue();
    }

    [Fact]
    public void HoursAfter_ShouldReturnExpected()
    {
        var futureValue = Now.AddHours(2.5);

        futureValue.Is().AtLeast(2).Hours().After(Now).Should().BeTrue();
        futureValue.Is().AtLeast(2.5).Hours().After(Now).Should().BeTrue();
        futureValue.Is().AtLeast(3).Hours().After(Now).Should().BeFalse();
    }


    [Fact]
    public void HoursBefore_ShouldReturnExpected()
    {
        var futureValue = Now.AddHours(2.5);

        Now.Is().AtLeast(2).Hours().Before(futureValue).Should().BeFalse();
        Now.Is().AtLeast(2.5).Hours().Before(futureValue).Should().BeTrue();
        Now.Is().AtLeast(3).Hours().Before(futureValue).Should().BeTrue();
    }


    [Fact]
    public void DaysAfter_ShouldReturnExpected()
    {
        var futureValue = Now.AddDays(2.5);

        futureValue.Is().AtLeast(2).Days().After(Now).Should().BeTrue();
        futureValue.Is().AtLeast(2.5).Days().After(Now).Should().BeTrue();
        futureValue.Is().AtLeast(3).Days().After(Now).Should().BeFalse();
    }


    [Fact]
    public void DaysBefore_ShouldReturnExpected()
    {
        var futureValue = Now.AddDays(2.5);

        Now.Is().AtLeast(2).Days().Before(futureValue).Should().BeFalse();
        Now.Is().AtLeast(2.5).Days().Before(futureValue).Should().BeTrue();
        Now.Is().AtLeast(3).Days().Before(futureValue).Should().BeTrue();
    }
}
