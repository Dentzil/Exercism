namespace Tests
{
    using NUnit.Framework;
    using System;
    using Exercism_collatz_conjecture;

    [TestFixture]
    public class CollatzConjectureTest
    {
        [Test]
        public void Zero_steps_for_one()
        {
            Assert.AreEqual(0, CollatzConjecture.Steps(1));
        }

        [Test]
        public void Divide_if_even()
        {
            Assert.AreEqual(4, CollatzConjecture.Steps(16));
        }

        [Test]
        public void Even_and_odd_steps()
        {
            Assert.AreEqual(9, CollatzConjecture.Steps(12));
        }

        [Test]
        public void Large_number_of_even_and_odd_steps()
        {
            Assert.AreEqual(152, CollatzConjecture.Steps(1000000));
        }

        [Test]
        public void Zero_is_an_error()
        {
            Assert.Throws<ArgumentException>(() => CollatzConjecture.Steps(0));
        }

        [Test]
        public void Negative_value_is_an_error()
        {
            Assert.Throws<ArgumentException>(() => CollatzConjecture.Steps(-15));
        }
    }
}
