namespace Ensure.Constants
{
    internal class ExceptionMessages
    {
        public static string NotNull => "Value can not be null";

        public static string IsNotNullOrWhiteSpace => "The string can not be left empty, null or consist of only whitespace";

        public static string IsNotNullOrEmpty => "The string can not be null or empty";

        public static string IsNotTrue => "Expected an expression that evaluates to true";

        public static string IsNotFalse => "Expected an expression that evaluates to false";

        public static string IsEmptyCollection => "";

        public static string IsNotInRangeToShort => "Excepted length of the string is too short";

        public static string IsNotInRangeToLong => "Expected length of the string is too long";
    }
}