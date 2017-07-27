using System;
using EnsureGuardClause.Extensions;
using EnsureGuardClause.UnitTests.Stubs;
using NUnit.Framework;

namespace EnsureGuardClause.UnitTests
{
    [TestFixture]
    public class ObjectExtensionsTests
    {
        [TestCase]
        public void That_ShouldThrowArgumentException_WhenTwoObjectsAreTheSame()
        {
            // arrange
            var value = new BasicStubOne();
            var actual = new BasicStubOne();

            // act
            TestDelegate action = () => Ensure.That(value).IsNotTheSameAs(actual);

            // assert
            Assert.Throws<ArgumentException>(action);
        }

        [TestCase]
        public void temp()
        {
            Ensure.That("", "", "").IsNotNull();
        }

        [TestCase]
        public void That_ShouldThrowArgumentException_WhenObjectIsNull()
        {
            // arrange
            object value = null;

            // act
            TestDelegate action = () => Ensure.That(value, "Foo").IsNotNull();

            // assert
            Assert.Throws<ArgumentNullException>(action);
        }

        [TestCase]
        public void That_ShouldNotThrowArgumentException_WhenObjectIsNotNull()
        {
            // arrange
            object value = new BasicStubOne();

            // act
            TestDelegate action = () => Ensure.That(value, "object").IsNotNull();

            // assert
            Assert.DoesNotThrow(action);
        }
    }
}
