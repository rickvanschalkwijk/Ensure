using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ensure
{
    public static class Ensure
    {
        public static Param<T> That<T>(T value, string name)
        {
            return new Param<T>(name, value);
        }
    }
}
