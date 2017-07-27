using System;

namespace EnsureGuardClause
{
    public abstract class Param
    {
        public Func<string> ExtraMessageFn;
        public readonly string Name;

        public Param(string name, Func<string> extraMessageFn = null)
        {
            Name = name;
            ExtraMessageFn = extraMessageFn;
        }
    }

    public class Param<T> : Param
    {
        public readonly T Value;
        public readonly T[] ListValue;

        public Param(string name, T value, Func<string> extraMessageFn = null)
            : base(name, extraMessageFn)
        {
            Value = value;
        }

        public Param(T[] value, Func<string> extraMessageFn = null)
          : base("", () => "")
        {
            ListValue = value;
        }

    }
}
