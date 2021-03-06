﻿using System;
using System.IO;

namespace EnsureGuardClause.Factories
{
    internal static class ExceptionFactory
    {
        internal static Exception CreateForParamValidation(Param param, string message)
        {
            return new ArgumentException(param.Name.ToString(), message);
        }

        internal static Exception CreateForParamNull(Param param, string message)
        {
            return new ArgumentNullException(param.ToString(), message);
        }

        internal static Exception CreateForDirectoryNotFound(Param param, string message)
        {
            return new DirectoryNotFoundException(message);
        }
    }
}
