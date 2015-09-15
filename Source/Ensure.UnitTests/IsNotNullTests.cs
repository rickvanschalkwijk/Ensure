using System;

using Ensure.Extensions;

using NUnit.Framework;

namespace Ensure.UnitTests
{
    [TestFixture]
    public class IsNotNullTests
    {
        [Test]
        [ExpectedException(typeof(ArgumentNullException))]
        public void That_ShouldThrowArgumentException()
        {
            object value = null;

            Ensure.That(value, "object").IsNotNull();
        }

        [Test]
        public void That_ShouldNotThrowArgumentException()
        {
            object value = new object();

            Ensure.That(value, "object").IsNotNull();
        }

        [Test]
        [ExpectedException(typeof(ArgumentNullException))]
        public void MethodName_ShouldDo_ReturnValue()
        {
            string value = null;

            Ensure.That(value, "sting").IsNotNull();
        }
    }
}
