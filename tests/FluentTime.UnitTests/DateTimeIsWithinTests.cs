using FluentAssertions;

namespace FluentTime.UnitTests;

public class DateTimeIsWithinTests
{
    public static readonly DateTime Now = DateTime.UtcNow;

    [Fact]
    public void SecondsOf_ReturnsExpected()
    {
        var futureValue = Now.AddSeconds(2.5);
        var pastValue = Now.AddSeconds(-2.5);

        Now.Is().Within(1).SecondsOf(futureValue).Should().BeFalse();
        Now.Is().Within(2.5).SecondsOf(futureValue).Should().BeTrue();
        Now.Is().Within(3).SecondsOf(futureValue).Should().BeTrue();
        Now.Is().Within(3).SecondsOf(pastValue).Should().BeTrue();
        Now.Is().Within(2.5).SecondsOf(pastValue).Should().BeTrue();
        Now.Is().Within(1).SecondsOf(pastValue).Should().BeFalse();
    }

    [Fact]
    public void MinutesOf_ReturnsExpected()
    {
        var futureValue = Now.AddMinutes(2.5);
        var pastValue = Now.AddMinutes(-2.5);

        Now.Is().Within(1).MinutesOf(futureValue).Should().BeFalse();
        Now.Is().Within(2.5).MinutesOf(futureValue).Should().BeTrue();
        Now.Is().Within(3).MinutesOf(futureValue).Should().BeTrue();
        Now.Is().Within(3).MinutesOf(pastValue).Should().BeTrue();
        Now.Is().Within(2.5).MinutesOf(pastValue).Should().BeTrue();
        Now.Is().Within(1).MinutesOf(pastValue).Should().BeFalse();
    }

    [Fact]
    public void HoursOf_ReturnsExpected()
    {
        var futureValue = Now.AddHours(2.5);
        var pastValue = Now.AddHours(-2.5);

        Now.Is().Within(1).HoursOf(futureValue).Should().BeFalse();
        Now.Is().Within(2.5).HoursOf(futureValue).Should().BeTrue();
        Now.Is().Within(3).HoursOf(futureValue).Should().BeTrue();
        Now.Is().Within(3).HoursOf(pastValue).Should().BeTrue();
        Now.Is().Within(2.5).HoursOf(pastValue).Should().BeTrue();
        Now.Is().Within(1).HoursOf(pastValue).Should().BeFalse();
    }


    [Fact]
    public void DaysOf_ReturnsExpected()
    {
        var futureValue = Now.AddDays(2.5);
        var pastValue = Now.AddDays(-2.5);

        Now.Is().Within(1).DaysOf(futureValue).Should().BeFalse();
        Now.Is().Within(2.5).DaysOf(futureValue).Should().BeTrue();
        Now.Is().Within(3).DaysOf(futureValue).Should().BeTrue();
        Now.Is().Within(3).DaysOf(pastValue).Should().BeTrue();
        Now.Is().Within(2.5).DaysOf(pastValue).Should().BeTrue();
        Now.Is().Within(1).DaysOf(pastValue).Should().BeFalse();
    }
}
