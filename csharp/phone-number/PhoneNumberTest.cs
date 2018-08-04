using NUnit.Framework;
using System;
using Exercism_phone_number;

namespace Tests
{
    [TestFixture()]
    public class Test
    {
        [Test]
        public void Cleans_the_number()
        {
            var phrase = "(223) 456-7890";
            Assert.AreEqual("2234567890", PhoneNumber.Clean(phrase));
        }

        [Test]
        public void Cleans_numbers_with_dots()
        {
            var phrase = "223.456.7890";
            Assert.AreEqual("2234567890", PhoneNumber.Clean(phrase));
        }

        [Test]
        public void Cleans_numbers_with_multiple_spaces()
        {
            var phrase = "223 456   7890   ";
            Assert.AreEqual("2234567890", PhoneNumber.Clean(phrase));
        }

        [Test]
        public void Invalid_when_9_digits()
        {
            var phrase = "123456789";
            Assert.Throws<ArgumentException>(() => PhoneNumber.Clean(phrase));
        }

        [Test]
        public void Invalid_when_11_digits_does_not_start_with_a_1()
        {
            var phrase = "22234567890";
            Assert.Throws<ArgumentException>(() => PhoneNumber.Clean(phrase));
        }

        [Test]
        public void Valid_when_11_digits_and_starting_with_1()
        {
            var phrase = "12234567890";
            Assert.AreEqual("2234567890", PhoneNumber.Clean(phrase));
        }

        [Test]
        public void Valid_when_11_digits_and_starting_with_1_even_with_punctuation()
        {
            var phrase = "+1 (223) 456-7890";
            Assert.AreEqual("2234567890", PhoneNumber.Clean(phrase));
        }

        [Test]
        public void Invalid_when_more_than_11_digits()
        {
            var phrase = "321234567890";
            Assert.Throws<ArgumentException>(() => PhoneNumber.Clean(phrase));
        }

        [Test]
        public void Invalid_with_letters()
        {
            var phrase = "123-abc-7890";
            Assert.Throws<ArgumentException>(() => PhoneNumber.Clean(phrase));
        }

        [Test]
        public void Invalid_with_punctuations()
        {
            var phrase = "123-@:!-7890";
            Assert.Throws<ArgumentException>(() => PhoneNumber.Clean(phrase));
        }

        [Test]
        public void Invalid_if_area_code_does_not_start_with_2_9()
        {
            var phrase = "(123) 456-7890";
            Assert.Throws<ArgumentException>(() => PhoneNumber.Clean(phrase));
        }

        [Test]
        public void Invalid_if_exchange_code_does_not_start_with_2_9()
        {
            var phrase = "(223) 056-7890";
            Assert.Throws<ArgumentException>(() => PhoneNumber.Clean(phrase));
        }
    }
}
