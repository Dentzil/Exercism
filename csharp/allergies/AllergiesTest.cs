namespace Tests
{
    using NUnit.Framework;
    using System;
    using System.Collections.Generic;
    using Exercism_allergies;

    [TestFixture()]
    public class AllergiesTest
    {
        [Test]
        public void No_allergies_means_not_allergic()
        {
            var allergies = new Allergies(0);
            Assert.False(allergies.AllergicTo("peanuts"));
            Assert.False(allergies.AllergicTo("cats"));
            Assert.False(allergies.AllergicTo("strawberries"));
        }

        [Test]
        public void Allergic_to_eggs()
        {
            var allergies = new Allergies(1);
            Assert.True(allergies.AllergicTo("eggs"));
        }

        [Test]
        public void Allergic_to_eggs_in_addition_to_other_stuff()
        {
            var allergies = new Allergies(5);
            Assert.True(allergies.AllergicTo("eggs"));
            Assert.True(allergies.AllergicTo("shellfish"));
            Assert.False(allergies.AllergicTo("strawberries"));
        }

        [Test]
        public void No_allergies_at_all()
        {
            var allergies = new Allergies(0);
            Assert.IsEmpty(allergies.List());
        }

        [Test]
        public void Allergic_to_just_eggs()
        {
            var allergies = new Allergies(1);
            Assert.AreEqual(new List<string> { "eggs" }, allergies.List());
        }

        [Test]
        public void Allergic_to_just_peanuts()
        {
            var allergies = new Allergies(2);
            Assert.AreEqual(new List<string> { "peanuts" }, allergies.List());
        }

        [Test]
        public void Allergic_to_eggs_and_peanuts()
        {
            var allergies = new Allergies(3);
            Assert.AreEqual(new List<string> { "eggs", "peanuts" }, allergies.List());
        }

        [Test]
        public void Allergic_to_lots_of_stuff()
        {
            var allergies = new Allergies(248);
            Assert.AreEqual(new List<string> { "strawberries", "tomatoes", "chocolate", "pollen", "cats" }, allergies.List());
        }

        [Test]
        public void Allergic_to_everything()
        {
            var allergies = new Allergies(255);
            Assert.AreEqual(new List<string>
                {
                    "eggs",
                    "peanuts",
                    "shellfish",
                    "strawberries",
                    "tomatoes",
                    "chocolate",
                    "pollen",
                    "cats"
                },
                    allergies.List());
        }

        [Test]
        public void Ignore_non_allergen_score_parts()
        {
            var allergies = new Allergies(509);
            Assert.AreEqual(new List<string>
                {
                    "eggs",
                    "shellfish",
                    "strawberries",
                    "tomatoes",
                    "chocolate",
                    "pollen",
                    "cats"
                }, allergies.List());
        }
    }
}
