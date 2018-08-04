namespace TwoFerTest
{
    using NUnit.Framework;
    using Exercism_two_fer;

    [TestFixture]
    public class TwoFerTest
    {
        [Test]
        public void No_name_given()
        {
            Assert.AreEqual("One for you, one for me.", TwoFer.Name());
        }

        [Test]
        public void A_name_given()
        {
            Assert.AreEqual("One for Alice, one for me.", TwoFer.Name("Alice"));
        }

        [Test]
        public void Another_name_given()
        {
            Assert.AreEqual("One for Bob, one for me.", TwoFer.Name("Bob"));
        }
    }
}