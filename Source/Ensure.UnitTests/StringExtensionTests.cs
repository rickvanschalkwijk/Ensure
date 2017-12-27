using System;
using Ensure.Extensions;
using Xunit;

namespace Ensure.UnitTests
{
    public class StringExtensionTests
    {
        [Fact]
        public void That_ShouldThrowArgumentException()
        {
            // arrange
            var value = string.Empty;

            // act
            // assert
            Assert.Throws<Exception>(() => Ensure.That(value, "object").IsNotEmpty());
        }

        [Fact]
        public void That_ShouldThrowArgumentException_()
        {
            // arrange
            // act
            // assert
            Assert.Throws<ArgumentNullException>(() => Ensure.That(null, "", "", "", "object").IsNotNull());
        }

        [Fact]
        public void IsNotEmpty_ShouldNotThrowException_ReturnVoid()
        {
            // arrange
            string value = "Foo";

            // act
            var exception = Record.Exception(() => Ensure.That(value, "string").IsNotEmpty());

            // assert
            Assert.Null(exception);
        }

        [Fact]
        public void HasLengthBetween_ShouldThrowExcepton_WhenStringIsNull()
        {
            // arrange
            // act
            // assert
            Assert.Throws<Exception>(() => Ensure.That((string) null).HasLengthBetween(0, 0));
        }

        [Fact]
        public void HasLengthBetween_ShouldThrowException_WhenLenghtIsLessThanMinLenght()
        {
            // arrange
            string value = "B";

            // act
            // assert
            Assert.Throws<ArgumentException>(() => Ensure.That(value).HasLengthBetween(2, 3));
        }

        [Fact]
        public void HasLenghtBetween_ShouldThrowException_WhenLenghtIsMoreThanMaxLenght()
        {
            // arrange
            string value = "Bar";

            // act
            // assert
            Assert.Throws<ArgumentException>(() => Ensure.That(value).HasLengthBetween(1, 2));
        }

        [Fact]
        public void HasLenghtBetween_ShouldReturnTheArgument_WhenLenghtIsBetweenMinAndMax()
        {
            // arrange
            string value = "Bar";

            // act
            var actual = Ensure.That(value).HasLengthBetween(1, 10);

            // assert
            Assert.Equal(actual.Value, value);
        }

        [Fact]
        public void IsNotWhiteSpace_ShouldReturnException_WhenParamIsNotWhiteSpace()
        {
            // arrange
            string value = "Bar";

            // act
            var actual = Ensure.That(value).IsNotWhiteSpace();

            // assert
            Assert.Equal(actual.Value, value);
        }

        [Fact]
        public void That_ShouldThrowException_WhenValueIsNull()
        {
            // arrange
            // act
            // assert
            Assert.Throws<ArgumentNullException>(() => Ensure.That((string) null, "sting").IsNotNull());
        }

        [Fact]
        public void ThatOverload_ShouldThrowException_WhenValueIsNull()
        {
            // arrange
            // act
            // assert
            Assert.Throws<ArgumentNullException>(() => Ensure.That((string) null).IsNotNull());
        }
    }
}
