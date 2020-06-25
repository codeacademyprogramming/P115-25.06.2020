using System;
using System.Collections.Generic;
using System.Text;

namespace _250620.Exceptions
{
    class ExamResultRangeException : SystemException
    {
        public ExamResultRangeException(string message) : base(message)
        {
        }
    }
}
