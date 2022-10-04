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

        Now.Is().Within(1).Seconds().Of(futureValue).Should().BeFalse();
        Now.Is().Within(2.5).Seconds().Of(futureValue).Should().BeTrue();
        Now.Is().Within(3).Seconds().Of(futureValue).Should().BeTrue();
        Now.Is().Within(3).Seconds().Of(pastValue).Should().BeTrue();
        Now.Is().Within(2.5).Seconds().Of(pastValue).Should().BeTrue();
        Now.Is().Within(1).Seconds().Of(pastValue).Should().BeFalse();
    }

    [Fact]
    public void MinutesOf_ReturnsExpected()
    {
        var futureValue = Now.AddMinutes(2.5);
        var pastValue = Now.AddMinutes(-2.5);

        Now.Is().Within(1).Minutes().Of(futureValue).Should().BeFalse();
        Now.Is().Within(2.5).Minutes().Of(futureValue).Should().BeTrue();
        Now.Is().Within(3).Minutes().Of(futureValue).Should().BeTrue();
        Now.Is().Within(3).Minutes().Of(pastValue).Should().BeTrue();
        Now.Is().Within(2.5).Minutes().Of(pastValue).Should().BeTrue();
        Now.Is().Within(1).Minutes().Of(pastValue).Should().BeFalse();
    }

    [Fact]
    public void HoursOf_ReturnsExpected()
    {
        var futureValue = Now.AddHours(2.5);
        var pastValue = Now.AddHours(-2.5);

        Now.Is().Within(1).Hours().Of(futureValue).Should().BeFalse();
        Now.Is().Within(2.5).Hours().Of(futureValue).Should().BeTrue();
        Now.Is().Within(3).Hours().Of(futureValue).Should().BeTrue();
        Now.Is().Within(3).Hours().Of(pastValue).Should().BeTrue();
        Now.Is().Within(2.5).Hours().Of(pastValue).Should().BeTrue();
        Now.Is().Within(1).Hours().Of(pastValue).Should().BeFalse();
    }


    [Fact]
    public void DaysOf_ReturnsExpected()
    {
        var futureValue = Now.AddDays(2.5);
        var pastValue = Now.AddDays(-2.5);

        Now.Is().Within(1).Days().Of(futureValue).Should().BeFalse();
        Now.Is().Within(2.5).Days().Of(futureValue).Should().BeTrue();
        Now.Is().Within(3).Days().Of(futureValue).Should().BeTrue();
        Now.Is().Within(3).Days().Of(pastValue).Should().BeTrue();
        Now.Is().Within(2.5).Days().Of(pastValue).Should().BeTrue();
        Now.Is().Within(1).Days().Of(pastValue).Should().BeFalse();
    }
}
