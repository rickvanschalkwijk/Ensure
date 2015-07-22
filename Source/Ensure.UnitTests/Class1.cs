using Ensure.Extensions;

using NUnit.Framework;

namespace Ensure.UnitTests
{
    [TestFixture]
    public class Class1
    {
        [Test]
       public void MethodName_ShouldDo_ReturnValue()
        {
            object value = null;

            Ensure.That(value, "object").IsNotNull();   
       }
    }
}
