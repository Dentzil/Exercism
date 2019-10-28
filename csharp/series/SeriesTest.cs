using System;

using Xunit;

public class SeriesTest
{
    [Fact]
    public void Slices_InputStringIsNull_ThrowsArgumentException()
    {
        // Arrange
        string testString = null;

        // Act + Assert
        var ex = Assert.Throws<ArgumentException>(() => Series.Slices(testString, 1));
        Assert.Equal("Empty input string.", ex.Message);
    }

    [Fact]
    public void Slices_ZeroLength_ThrowsArgumentException()
    {
        // Arrange
        int length = 0;

        // Act + Assert
        var ex = Assert.Throws<ArgumentException>(() => Series.Slices("12345", length));
        Assert.Equal("Slice length must be greather than 0.", ex.Message);
    }

    [Fact]
    public void Slices_LengthLessThanZero_ThrowsArgumentException()
    {
        // Arrange
        int length = -1;

        // Act + Assert
        var ex = Assert.Throws<ArgumentException>(() => Series.Slices("12345", length));
        Assert.Equal("Slice length must be greather than 0.", ex.Message);
    }

    [Fact]
    public void Slices_OneFromOne_ReturnsOneSerie()
    {
        // Arrange
        string testInput = "1";
        int testLength = 1;
        var expectedSeries = new[] { "1" };

        // Act
        var actualSeries = Series.Slices(testInput, testLength);

        // Assert
        Assert.Equal(expectedSeries, actualSeries);
    }

    [Fact]
    public void Slices_OneFromTwo_ReturnsTwoSeries()
    {
        // Arrange
        string testInput = "12";
        int testLength = 1;
        var expectedSeries = new[] { "1", "2" };

        // Act
        var actualSeries = Series.Slices(testInput, testLength);

        // Assert
        Assert.Equal(expectedSeries, actualSeries);
    }

    [Fact]
    public void Slices_TwoFromTwo_ReturnsOneSerie()
    {
        // Arrange
        string testInput = "35";
        int testLength = 2;
        var expectedSeries = new[] { "35" };

        // Act
        var actualSeries = Series.Slices(testInput, testLength);

        // Assert
        Assert.Equal(expectedSeries, actualSeries);
    }

    [Fact]
    public void Slices_TwoFromManyWithOverlapping_ReturnsAppropriateSeries()
    {
        // Arrange
        string testInput = "9142";
        int testLength = 2;
        var expectedSeries = new[] { "91", "14", "42" };

        // Act
        var actualSeries = Series.Slices(testInput, testLength);

        // Assert
        Assert.Equal(expectedSeries, actualSeries);
    }

    [Fact]
    public void Slices_WithDuplicates_ReturnsAppropriateSeries()
    {
        // Arrange
        string testInput = "777777";
        int testLength = 3;
        var expectedSeries = new[] { "777", "777", "777", "777" };

        // Act
        var actualSeries = Series.Slices(testInput, testLength);

        // Assert
        Assert.Equal(expectedSeries, actualSeries);
    }

    [Fact]
    public void Slices_LongInput_ReturnsAppropriatesSeries()
    {
        // Arrange
        string testInput = "918493904243";
        int testLength = 5;
        var expectedSeries = new[] { "91849", "18493", "84939", "49390", "93904", "39042", "90424", "04243" };

        // Act
        var actualSeries = Series.Slices(testInput, testLength);

        // Assert
        Assert.Equal(expectedSeries, actualSeries);
    }

    [Fact]
    public void Slice_LengthTooLarge_ReturnsWholeString()
    {
        // Arrange
        string testInput = "12345";
        int testLength = 10;
        var expectedSeries = new[] { "12345" };

        // Act
        var actualSeries = Series.Slices(testInput, testLength);

        // Assert
        Assert.Equal(expectedSeries, actualSeries);
    }
}
