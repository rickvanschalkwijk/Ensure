using System;

using Ensure.Extensions;

using NUnit.Framework;

namespace Ensure.UnitTests
{
    [TestFixture]
    public class StringExtensionTests
    {
        [Test]
        public void That_ShouldThrowArgumentException()
        {
            // arrange
            var value = string.Empty;

            // act
            TestDelegate action = () => Ensure.That(value, "object").IsNotEmpty();

            // assert
            Assert.Throws<Exception>(action);
        }

        [Test]
        public void IsNotEmpty_ShouldNotThrowException_ReturnVoid()
        {
            // arrange
            string value = "Foo";

            // act
            TestDelegate action = () => Ensure.That(value, "sting").IsNotEmpty();

            // assert
            Assert.DoesNotThrow(action);
        }

        [Test]
        public void HasLengthBetween_ShouldThrowExcepton_WhenStringIsNull()
        {
            // arrange
            string value = null;

            // act
            TestDelegate action = () => Ensure.That(value).HasLengthBetween(0,0);

            // assert
            Assert.Throws<Exception>(action);
        }

        [Test]
        public void HasLengthBetween_ShouldThrowException_WhenLenghtIsLessThanMinLenght()
        {
            // arrange
            string value = "Bar";

            // act
            TestDelegate action = () => Ensure.That(value).HasLengthBetween(1, 2);

            // assert
            Assert.Throws<ArgumentException>(action, "Excepted length of the string is too short", "Bar");
        }

        [Test]
        public void HasLenghtBetween_ShouldThrowException_WhenLenghtIsMoreThanMaxLenght()
        {
            // arrange
            string value = "Bar";

            // act
            TestDelegate action = () => Ensure.That(value).HasLengthBetween(1, 2);

            // assert
            Assert.Throws<ArgumentException>(action, "Excepted length of the string is too long", "Bar");
        }

        [Test]
        public void HasLenghtBetween_ShouldReturnTheArgument_WhenLenghtIsBetweenMinAndMax()
        {
            // arrange
            string value = "Bar";

            // act
            var actual = Ensure.That(value).HasLengthBetween(1, 10);

            // assert
            Assert.That(actual.Value, Is.EqualTo("Bar"));
        }

        [Test]
        public void IsNotWhiteSpace_ShouldReturnException_WhenParamIsNotWhiteSpace()
        {
            // arrange
            string value = "Bar";

            // act
            var actual = Ensure.That(value).IsNotWhiteSpace();

            // assert
            Assert.That(actual.Value, Is.EqualTo("Bar"));
        }
    }
}
