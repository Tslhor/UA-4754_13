using System;
using ViewTask.Services;
using Xunit;

namespace ViewTask.Tests;

public class TimeServiceTests
{
    [Fact]
    public void GetTimeForTomorrow_ReturnsTomorrowInExpectedFormat()
    {
        var expected = DateTime.Now.AddDays(1).ToString("dd/MM/yyyy");

        var result = new SimpleTimeService().GetTimeForTomorrow();

        Assert.Equal(expected, result);
    }
}
