using FluentAssertions;

namespace FluentTime.UnitTests;

public class DateTiimeIsTests
{
    public static readonly DateTime Now = DateTime.UtcNow;

    [Fact]
    public void After_ReturnsExpected()
    {
        var futureValue = Now.AddSeconds(2.5);

        Now.Is().After(futureValue).Should().BeFalse();
        Now.Is().After(Now).Should().BeFalse();
        futureValue.Is().After(Now).Should().BeTrue();
    }

    [Fact]
    public void Before_ReturnsExpected()
    {
        var futureValue = Now.AddSeconds(2.5);

        Now.Is().Before(futureValue).Should().BeTrue();
        Now.Is().Before(Now).Should().BeFalse();
        futureValue.Is().Before(Now).Should().BeFalse();
    }
}
