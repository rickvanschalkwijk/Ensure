﻿using System;

using Ensure.Constants;
using Ensure.Factories;

namespace Ensure.Extensions
{
    public static class StringExtensions
    {
        public static void IsNotNull(this Param<string> param)
        {
            if (param.Value == null)
            {
                throw new ArgumentNullException(ExceptionMessages.NotNull);
            }
        }

        public static void IsNotEmpty(this Param<string> param)
        {
            if (param.Value == string.Empty)
            {
                throw new Exception(ExceptionMessages.NotNull);
            }
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
                throw new Exception(ExceptionMessages.IsNotInRange_ToShort);
            }

            if (length > maxLength)
            {
                throw ExceptionFactory.CreateForParamValidation(
                    param,
                    ExceptionMessages.IsNotInRange_ToLong);
            }

            return param;
        }
    }
}
