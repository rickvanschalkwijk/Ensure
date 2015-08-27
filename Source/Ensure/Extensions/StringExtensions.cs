using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ensure.Extensions
{
    public static class StringExtensions
    {
        public static void IsNotEmpty(this Param<string> param)
        {
            if (param.Value == string.Empty)
            {
                throw new ex
            }
        }
    }
}
