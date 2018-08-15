using Xunit;

public class LeapTest
{
    [Fact]
    public void Valid_leap_year()
    {
        Assert.Equal(true, Year.IsLeap(1996));
    }

    [Fact]
    public void Invalid_leap_year()
    {
        Assert.Equal(false, Year.IsLeap(1997));
    }

    [Fact]
    public void Turn_of_the_20th_century_is_not_a_leap_year()
    {
        Assert.Equal(false, Year.IsLeap(1900));
    }

    [Fact]
    public void Turn_of_the_25th_century_is_a_leap_year()
    {
        Assert.Equal(true, Year.IsLeap(2400));
    }
}
