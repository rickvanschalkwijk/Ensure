using System;
using System.IO;

namespace Ensure.Factories
{
    internal static class ExceptionFactory
    {
        public static Exception CreateForParamValidation(Param param, string message)
        {
            return new ArgumentException(param.ToString(), message);
        }

        public static Exception CreateForParamNull(Param param, string message)
        {
            return new ArgumentNullException(param.ToString(), message);
        }

        public static Exception CreateForDirectoryNotFound(Param param, string message)
        {
            return new DirectoryNotFoundException(message);
        }
    }
}
