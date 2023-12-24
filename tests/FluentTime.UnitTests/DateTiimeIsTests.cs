using FluentAssertions;

namespace FluentTime.UnitTests;

public class DateTiimeIsTests
{
    [Fact]
    public void After_ReturnsExpected()
    {
        var thePresent = DateTime.UtcNow;
        var thePast = thePresent.AddSeconds(2.5);

        thePresent.IsAfter(thePast).Should().BeFalse();
        thePresent.IsAfter(thePresent).Should().BeFalse();
        thePast.IsAfter(thePresent).Should().BeTrue();
    }

    [Fact]
    public void Before_ReturnsExpected()
    {
        var thePresent = DateTime.UtcNow;
        var futureValue = thePresent.AddSeconds(2.5);

        thePresent.IsBefore(futureValue).Should().BeTrue();
        thePresent.IsBefore(thePresent).Should().BeFalse();
        futureValue.IsBefore(thePresent).Should().BeFalse();
    }
}
