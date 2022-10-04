using FluentAssertions;

namespace FluentTime.UnitTests;

public class DateTiimeIsTests
{
    [Fact]
    public void After_ReturnsExpected()
    {
        var thePresent = DateTime.UtcNow;
        var thePast = thePresent.AddSeconds(2.5);

        thePresent.Is().After(thePast).Should().BeFalse();
        thePresent.Is().After(thePresent).Should().BeFalse();
        thePast.Is().After(thePresent).Should().BeTrue();
    }

    [Fact]
    public void Before_ReturnsExpected()
    {
        var thePresent = DateTime.UtcNow;
        var futureValue = thePresent.AddSeconds(2.5);

        thePresent.Is().Before(futureValue).Should().BeTrue();
        thePresent.Is().Before(thePresent).Should().BeFalse();
        futureValue.Is().Before(thePresent).Should().BeFalse();
    }
}
