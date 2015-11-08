namespace Ensure
{
    public static class Ensure
    {
        public static Param<T> That<T>(T value, string name)
        {
            return new Param<T>(name, value);
        }

        public static Param<T> That<T>(T value)
        {
            return new Param<T>(value.ToString(), value);
        }
    }
}
