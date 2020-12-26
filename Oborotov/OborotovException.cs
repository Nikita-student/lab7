using System;

namespace Oborotov
{
    class OborotovException : Exception
    {
        public OborotovException(string message)
        : base(message)
        { }
    }
}