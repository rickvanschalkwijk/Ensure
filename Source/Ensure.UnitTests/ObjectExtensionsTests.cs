using System;
using Ensure.Extensions;
using Xunit;

namespace Ensure.UnitTests
{
    public class ObjectExtensionsTests
    {
        [Fact]
        public void That_ShouldThrowArgumentException_WhenObjectIsNull()
        {
            // arrange
            object value = null;

            // act
            // assert
            Assert.Throws<ArgumentNullException>(() => Ensure.That(value, "Foo").IsNotNull());
        }
    }
}
