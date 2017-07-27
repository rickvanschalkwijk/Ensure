using System;
using EnsureGuardClause.Extensions;
using NUnit.Framework;

namespace EnsureGuardClause.UnitTests
{
    [TestFixture]
    public class StringExtensionTests
    {
        [TestCase]
        public void That_ShouldThrowArgumentException()
        {
            // arrange
            var value = string.Empty;

            // act
            TestDelegate action = () => Ensure.That(value, "object").IsNotEmpty();

            // assert
            Assert.Throws<Exception>(action);
        }

        [TestCase]
        public void That_ShouldThrowArgumentException_()
        {
            // arrange
            var value = string.Empty;

            // act
            TestDelegate action = () => Ensure.That(null,"","", "object").IsNotNull();

            // assert
            Assert.Throws<ArgumentNullException>(action);
        }

        [TestCase]
        public void IsNotEmpty_ShouldNotThrowException_ReturnVoid()
        {
            // arrange
            string value = "Foo";

            // act
            TestDelegate action = () => Ensure.That(value, "sting").IsNotEmpty();

            // assert
            Assert.DoesNotThrow(action);
        }

        [TestCase]
        public void HasLengthBetween_ShouldThrowExcepton_WhenStringIsNull()
        {
            // arrange
            string value = null;

            // act
            TestDelegate action = () => Ensure.That(value).HasLengthBetween(0, 0);

            // assert
            Assert.Throws<Exception>(action);
        }

        [TestCase]
        public void HasLengthBetween_ShouldThrowException_WhenLenghtIsLessThanMinLenght()
        {
            // arrange
            string value = "Bar";

            // act
            TestDelegate action = () => Ensure.That(value).HasLengthBetween(1, 2);

            // assert
            Assert.Throws<ArgumentException>(action, "Excepted length of the string is too short", "Bar");
        }

        [TestCase]
        public void HasLenghtBetween_ShouldThrowException_WhenLenghtIsMoreThanMaxLenght()
        {
            // arrange
            string value = "Bar";

            // act
            TestDelegate action = () => Ensure.That(value).HasLengthBetween(1, 2);

            // assert
            Assert.Throws<ArgumentException>(action, "Excepted length of the string is too long", "Bar");
        }

        [TestCase]
        public void HasLenghtBetween_ShouldReturnTheArgument_WhenLenghtIsBetweenMinAndMax()
        {
            // arrange
            string value = "Bar";

            // act
            var actual = Ensure.That(value).HasLengthBetween(1, 10);

            // assert
            Assert.That(actual.Value, Is.EqualTo("Bar"));
        }

        [TestCase]
        public void IsNotWhiteSpace_ShouldReturnException_WhenParamIsNotWhiteSpace()
        {
            // arrange
            string value = "Bar";

            // act
            var actual = Ensure.That(value).IsNotWhiteSpace();

            // assert
            Assert.That(actual.Value, Is.EqualTo("Bar"));
        }

        [TestCase]
        public void That_ShouldThrowException_WhenValueIsNull()
        {
            string value = null;

            TestDelegate action = () => Ensure.That(value, "sting").IsNotNull();

            Assert.Throws<ArgumentNullException>(action);
        }

        [TestCase]
        public void ThatOverload_ShouldThrowException_WhenValueIsNull()
        {
            string stringValue = null;

            TestDelegate action = () => Ensure.That(stringValue).IsNotNull();

            Assert.Throws<ArgumentNullException>(action);
        }
    }
}
