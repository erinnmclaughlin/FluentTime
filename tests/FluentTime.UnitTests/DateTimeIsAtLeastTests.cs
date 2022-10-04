using FluentAssertions;

namespace FluentTime.UnitTests;

public class DateTimeIsAtLeastTests
{
    public static readonly DateTime Now = DateTime.UtcNow;

    [Fact]
    public void SecondsAfter_ShouldReturnExpected()
    {
        var futureValue = Now.AddSeconds(2.5);

        futureValue.Is().AtLeast(2).SecondsAfter(Now).Should().BeTrue();
        futureValue.Is().AtLeast(2.5).SecondsAfter(Now).Should().BeTrue();
        futureValue.Is().AtLeast(3).SecondsAfter(Now).Should().BeFalse();
    }

    [Fact]
    public void SecondsBefore_ShouldReturnExpected()
    {
        var futureValue = Now.AddSeconds(2.5);

        Now.Is().AtLeast(2).SecondsBefore(futureValue).Should().BeFalse();
        Now.Is().AtLeast(2.5).SecondsBefore(futureValue).Should().BeTrue();
        Now.Is().AtLeast(3).SecondsBefore(futureValue).Should().BeTrue();
    }

    [Fact]
    public void MinutesAfter_ShouldReturnExpected()
    {
        var futureValue = Now.AddMinutes(2.5);

        futureValue.Is().AtLeast(2).MinutesAfter(Now).Should().BeTrue();
        futureValue.Is().AtLeast(2.5).MinutesAfter(Now).Should().BeTrue();
        futureValue.Is().AtLeast(3).MinutesAfter(Now).Should().BeFalse();
    }

    [Fact]
    public void MinutesBefore_ShouldReturnExpected()
    {
        var futureValue = Now.AddMinutes(2.5);

        Now.Is().AtLeast(2).MinutesBefore(futureValue).Should().BeFalse();
        Now.Is().AtLeast(2.5).MinutesBefore(futureValue).Should().BeTrue();
        Now.Is().AtLeast(3).MinutesBefore(futureValue).Should().BeTrue();
    }

    [Fact]
    public void HoursAfter_ShouldReturnExpected()
    {
        var futureValue = Now.AddHours(2.5);

        futureValue.Is().AtLeast(2).HoursAfter(Now).Should().BeTrue();
        futureValue.Is().AtLeast(2.5).HoursAfter(Now).Should().BeTrue();
        futureValue.Is().AtLeast(3).HoursAfter(Now).Should().BeFalse();
    }


    [Fact]
    public void HoursBefore_ShouldReturnExpected()
    {
        var futureValue = Now.AddHours(2.5);

        Now.Is().AtLeast(2).HoursBefore(futureValue).Should().BeFalse();
        Now.Is().AtLeast(2.5).HoursBefore(futureValue).Should().BeTrue();
        Now.Is().AtLeast(3).HoursBefore(futureValue).Should().BeTrue();
    }


    [Fact]
    public void DaysAfter_ShouldReturnExpected()
    {
        var futureValue = Now.AddDays(2.5);

        futureValue.Is().AtLeast(2).DaysAfter(Now).Should().BeTrue();
        futureValue.Is().AtLeast(2.5).DaysAfter(Now).Should().BeTrue();
        futureValue.Is().AtLeast(3).DaysAfter(Now).Should().BeFalse();
    }


    [Fact]
    public void DaysBefore_ShouldReturnExpected()
    {
        var futureValue = Now.AddDays(2.5);

        Now.Is().AtLeast(2).DaysBefore(futureValue).Should().BeFalse();
        Now.Is().AtLeast(2.5).DaysBefore(futureValue).Should().BeTrue();
        Now.Is().AtLeast(3).DaysBefore(futureValue).Should().BeTrue();
    }
}
