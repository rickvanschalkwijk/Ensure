using System;

using Ensure.Extensions;

using NUnit.Framework;

namespace Ensure.UnitTests
{
    [TestFixture]
    public class IsNotNullTests
    {
        [TestCase]
        public void That_ShouldThrowArgumentException()
        {
            object value = null;

            TestDelegate action = () => Ensure.That(value, "Foo").IsNotNull();

            Assert.Throws<ArgumentNullException>(action);
        }

        [TestCase]
        public void That_ShouldNotThrowArgumentException()
        {
            object value = new object();

            TestDelegate action = () => Ensure.That(value, "object").IsNotNull();

            Assert.DoesNotThrow(action);
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
