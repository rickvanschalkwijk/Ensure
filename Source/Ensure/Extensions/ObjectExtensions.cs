using System;

namespace Ensure.Extensions
{
    public static class ObjectExtensions
    {
        public static void IsNotNull(this Param<object> param)
        {
            if (param.Value == null)
            {
                throw new ArgumentNullException();
            }
        }
    }
}
