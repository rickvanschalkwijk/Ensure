namespace Ensure.Constants
{
    internal class ExceptionMessages
    {
        public static string NotNull
        {
            get
            {
                return "Value can not be null";
            }
        }

        public static string IsNotNullOrWhiteSpace
        {
            get
            {
                return "The string can not be left empty, null or consist of only whitespace";
            }
        }

        public static string IsNotNullOrEmpty
        {
            get
            {
                return "The string can not be null or empty";
            }
        }

        public static string IsNotTrue
        {
            get
            {
                return "Expected an expression that evaluates to true";
            }
        }

        public static string IsNotFalse
        {
            get
            {
                return "Expected an expression that evaluates to false";
            }
        }

        public static string IsEmptyCollection
        {
            get
            {
                return "";
            }
        }

        public static string IsNotInRange_ToShort
        {
            get
            {
                return "Excepted length of the string is too short";
            }
        }

        public static string IsNotInRange_ToLong
        {
            get
            {
                return "Expected length of the string is too long";
            }
        }
    }
}
