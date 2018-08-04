namespace Tests
{
    using NUnit.Framework;
    using System;
    using Exercism_saddle_points;

    [TestFixture]
    public class SaddlePointsTest
    {
        [Test]
        public void Can_identify_single_saddle_point()
        {
            var input = new[,]
            {
            { 9, 8, 7 },
            { 5, 3, 2 },
            { 6, 6, 7 }
        };
            var sut = new SaddlePoints(input);
            var actual = sut.Calculate();
            var expected = new[] { Tuple.Create(1, 0) };
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Can_identify_that_empty_matrix_has_no_saddle_points()
        {
            var input = new int[,] { };
            var sut = new SaddlePoints(input);
            var actual = sut.Calculate();
            Assert.IsEmpty(actual);
        }

        [Test]
        public void Can_identify_lack_of_saddle_points_when_there_are_none()
        {
            var input = new[,]
            {
            { 1, 2, 3 },
            { 3, 1, 2 },
            { 2, 3, 1 }
        };
            var sut = new SaddlePoints(input);
            var actual = sut.Calculate();
            Assert.IsEmpty(actual);
        }

        [Test]
        public void Can_identify_multiple_saddle_points()
        {
            var input = new[,]
            {
            { 4, 5, 4 },
            { 3, 5, 5 },
            { 1, 5, 4 }
        };
            var sut = new SaddlePoints(input);
            var actual = sut.Calculate();
            var expected = new[] { Tuple.Create(0, 1), Tuple.Create(1, 1), Tuple.Create(2, 1) };
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Can_identify_saddle_point_in_bottom_right_corner()
        {
            var input = new[,]
            {
            { 8, 7, 9 },
            { 6, 7, 6 },
            { 3, 2, 5 }
        };
            var sut = new SaddlePoints(input);
            var actual = sut.Calculate();
            var expected = new[] { Tuple.Create(2, 2) };
            Assert.AreEqual(expected, actual);
        }
    }
}
