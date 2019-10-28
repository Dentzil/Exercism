using System;

using Xunit;

public class ResistorColorTest
{
    [Fact]
    public void ColorCode_ColorIsNull_ThrowsArgumentNullException()
    {
        // Arrange
        string testColor = null;

        // Act + Assert
        Assert.Throws<ArgumentNullException>(() => ResistorColor.ColorCode(testColor));
    }

    [Fact]
    public void ColorCode_UnknownColor_ThrowsArgumentException()
    {
        // Arrange
        string testColor = "unknown";

        // Act + Assert
        ArgumentException ex = Assert.Throws<ArgumentException>(() => ResistorColor.ColorCode(testColor));
        Assert.Equal($"Unknown color: {testColor}", ex.Message);
    }

    [Theory]
    [InlineData("black", 0)]
    [InlineData("brown", 1)]
    [InlineData("red", 2)]
    [InlineData("orange", 3)]
    [InlineData("yellow", 4)]
    [InlineData("green", 5)]
    [InlineData("blue", 6)]
    [InlineData("violet", 7)]
    [InlineData("grey", 8)]
    [InlineData("white", 9)]
    public void ColorCode_ForEachColor_ReturnsAppropriateNumber(string testColor, int expectedNumber)
    {
        // Act
        int actualNumber = ResistorColor.ColorCode(testColor);

        // Assert
        Assert.Equal(expectedNumber, actualNumber);
    }

    [Fact]
    public void Colors_ReturnsAllColors()
    {
        // Arrange
        var expectedColors = new[] { "black", "brown", "red", "orange", "yellow", "green", "blue", "violet", "grey", "white" };

        // Act
        var actualColors = ResistorColor.Colors();

        // Assert
        Assert.Equal(expectedColors, actualColors);
    }
}
