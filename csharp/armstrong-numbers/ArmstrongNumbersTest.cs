namespace Tests
{
    using NUnit.Framework;
    using Exercism_armstrong_number;

    [TestFixture()]
    public class ArmstrongNumbersTest
    {
        [Test]
        public void Null_is_not_armstrong_number()
        {
            Assert.True(ArmstrongNumbers.IsArmstrongNumber(0));
        }

        [Test]
        public void Single_digit_numbers_are_armstrong_numbers()
        {
            Assert.True(ArmstrongNumbers.IsArmstrongNumber(5));
        }

        [Test]
        public void There_are_no_2_digit_armstrong_numbers()
        {
            Assert.False(ArmstrongNumbers.IsArmstrongNumber(10));
        }

        [Test]
        public void Three_digit_number_that_is_an_armstrong_number()
        {
            Assert.True(ArmstrongNumbers.IsArmstrongNumber(153));
        }

        [Test]
        public void Three_digit_number_that_is_not_an_armstrong_number()
        {
            Assert.False(ArmstrongNumbers.IsArmstrongNumber(100));
        }

        [Test]
        public void Four_digit_number_that_is_an_armstrong_number()
        {
            Assert.True(ArmstrongNumbers.IsArmstrongNumber(9474));
        }

        [Test]
        public void Four_digit_number_that_is_not_an_armstrong_number()
        {
            Assert.False(ArmstrongNumbers.IsArmstrongNumber(9475));
        }

        [Test]
        public void Seven_digit_number_that_is_an_armstrong_number()
        {
            Assert.True(ArmstrongNumbers.IsArmstrongNumber(9926315));
        }

        [Test]
        public void Seven_digit_number_that_is_not_an_armstrong_number()
        {
            Assert.False(ArmstrongNumbers.IsArmstrongNumber(9926314));
        }
    }
}
