using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
