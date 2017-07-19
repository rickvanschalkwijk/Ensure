using System;

using Ensure.Extensions;

using NUnit.Framework;

namespace Ensure.UnitTests
{
    [TestFixture]
    public class IsNotEmptyTests
    {
        [Test]
        [ExpectedException(typeof(ArgumentNullException))]
        public void That_ShouldThrowArgumentException()
        {
            var value = string.Empty;

            Ensure.That(value, "object").IsNotEmpty();
        }

        [Test]
        [ExpectedException(typeof(ArgumentNullException))]
        public void MethodName_ShouldDo_ReturnValue()
        {
            string value = "Foo";

            Ensure.That(value, "sting").IsNotEmpty();
        }
    }
}
