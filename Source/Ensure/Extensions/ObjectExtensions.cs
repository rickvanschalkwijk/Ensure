﻿using System;

using Ensure.Constants;

namespace Ensure.Extensions
{
    public static class ObjectExtensions
    {
        public static void IsNotNull(this Param<object> param)
        {
            if (param.Value == null)
            {
                throw new ArgumentNullException(ExceptionMessages.NotNull);
            }
        }
    }
}
