using _250620.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace _250620
{
    class Student
    {
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public int ExamResult { get; private set; }
        public string Group { get;private set; }

        public void SetGroup(string groupName)
        {
            if (string.IsNullOrEmpty(groupName)) throw new ArgumentNullException("groupName");

            if (groupName.Length != 4) throw new ArgumentOutOfRangeException("groupName");

            this.Group = groupName;
        }

        public void SetExamResult(int result)
        {
            if (result < 0 || result > 100) throw new ArgumentOutOfRangeException("result");

            this.ExamResult = result;
        }
    }
}
