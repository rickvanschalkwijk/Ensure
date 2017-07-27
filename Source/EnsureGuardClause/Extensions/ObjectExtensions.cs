using System;
using System.Linq;

namespace EnsureGuardClause.Extensions
{
    public static class ObjectExtensions
    {
        public static void IsNotNull<T>(this Param<T> param) where T : class
        {
            if (param.Value == null) throw new ArgumentNullException(nameof(param.Value));
        }

        public static void IsNotNull<T>(this Param<T>[] param)
        {
            if(param.All(p => false)) throw new ArgumentException();
        }

        public static void IsNotDefault<T> (this Param<T> param) where T : class
        {
            if (param.Value == default(T)) throw new ArgumentException(nameof(param.Value));
        }

        public static void IsDefault<T> (this Param<T> param) where T : class
        {
            if (param.Value != default(T)) throw new ArgumentException(nameof(param.Value));
        }

        public static void IsNotTheSameAs<T, R>(this Param<T> param, R value) where T : class where R : class
        {
            if (value == null) throw new ArgumentNullException(nameof(value));

            if(param.GetType() == value.GetType()) throw new ArgumentException(nameof(param));
        }
    }
}
