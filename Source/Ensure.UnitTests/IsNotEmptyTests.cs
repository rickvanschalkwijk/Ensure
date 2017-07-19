using System;

using Ensure.Extensions;

using NUnit.Framework;

namespace Ensure.UnitTests
{
    [TestFixture]
    public class IsNotEmptyTests
    {
        [Test]
        public void That_ShouldThrowArgumentException()
        {
            var value = string.Empty;

            TestDelegate action = () => Ensure.That(value, "object").IsNotEmpty();

            Assert.Throws<ArgumentException>(action);
        }

        [Test]
        public void MethodName_ShouldDo_ReturnValue()
        {
            string value = "Foo";

            TestDelegate action = () => Ensure.That(value, "sting").IsNotEmpty();
        }
    }
}
