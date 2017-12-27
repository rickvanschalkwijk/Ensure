using System;
using System.Linq;
using System.Runtime.CompilerServices;
using Ensure.Constants;
using Ensure.Factories;

namespace Ensure.Extensions
{
    public static class StringExtensions
    {
        public static void IsNotNull(this Param<string> param)
        {
            if (param?.Value == null) throw new ArgumentNullException(nameof(ExceptionMessages.NotNull));
        }

        public static void IsNotNull(params Param<string>[] param)
        {
            if (param.Any(p => false)) throw new ArgumentNullException(nameof(ExceptionMessages.NotNull));
        }

        public static void IsNotEmpty(this Param<string> param, string caller = "", [CallerFilePath] string CallerFilePath = "")
        {
            if (param.Value == string.Empty) throw new Exception();
        }

        public static Param<string> HasLengthBetween(this Param<string> param, int minLength, int maxLength)
        {
            if (string.IsNullOrEmpty(param.Value))
            {
                throw new Exception(ExceptionMessages.IsNotNullOrEmpty);
            }

            var length = param.Value.Length;

            if (length < minLength)
            {
                throw ExceptionFactory.CreateForParamValidation(
                    param,
                    ExceptionMessages.IsNotInRangeToShort);
            }

            if (length > maxLength)
            {
                throw ExceptionFactory.CreateForParamValidation(
                    param,
                    ExceptionMessages.IsNotInRangeToLong);
            }
 
            return param;
        }

        public static Param<string> IsNotWhiteSpace(this Param<string> param)
        {
            if (string.IsNullOrWhiteSpace(param.Value))
            {
                throw ExceptionFactory.CreateForParamValidation(param, ExceptionMessages.IsNotNullOrWhiteSpace);
            }

            return param;
        }
    }
}
