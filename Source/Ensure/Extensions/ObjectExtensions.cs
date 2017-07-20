using System;

namespace Ensure.Extensions
{
    public static class ObjectExtensions
    {
        public static void IsNotNull<T>(this Param<T> param) where T : class
        {
            if (param.Value == null) throw new ArgumentNullException(nameof(param.Value));
        }

        public static void IsNotDefault<T> (this Param<T> param) where T : class
        {
            if (param.Value == default(T)) throw new ArgumentException(nameof(param.Value));
        }

        public static void IsDefault<T> (this Param<T> param) where T : class
        {
            if (param.Value != default(T)) throw new ArgumentException(nameof(param.Value));
        }
    }
}
