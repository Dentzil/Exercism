namespace Tests
{
    using NUnit.Framework;
    using Exercism_reverse_string;

    [TestFixture]
    public class ReverseStringTest
    {
        [Test]
        public void An_empty_string()
        {
            Assert.AreEqual("", ReverseString.Reverse(""));
        }

        [Test]
        public void A_word()
        {
            Assert.AreEqual("tobor", ReverseString.Reverse("robot"));
        }

        [Test]
        public void A_capitalized_word()
        {
            Assert.AreEqual("nemaR", ReverseString.Reverse("Ramen"));
        }

        [Test]
        public void A_sentence_with_punctuation()
        {
            Assert.AreEqual("!yrgnuh m'I", ReverseString.Reverse("I'm hungry!"));
        }

        [Test]
        public void A_palindrome()
        {
            Assert.AreEqual("racecar", ReverseString.Reverse("racecar"));
        }
    }
}
