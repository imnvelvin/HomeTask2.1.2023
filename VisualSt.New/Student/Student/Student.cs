using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace Student
{
    internal class Student
    {
        public Student()
        {
            _totalCount++;
            No = _totalCount;
        }
        public string Name;
        public int No;
        public string _groupNo;

        public string GroupNo
        {
            set
            {
                if (CheckGroupNo(value))
                {
                    _groupNo = value;
                }
            }
            get
            {
                return _groupNo;
            }
        }

        static int _totalCount;

        public bool CheckGroupNo(string str)
        {
            if (string.IsNullOrWhiteSpace(str) && str.Length != 4)
            {
                return false;
            }
            if (!char.IsUpper(str[0]))
            {
                return false;
            }
            for (int i = 1; i < str.Length; i++)
            {
                if (!char.IsDigit(str[i]))
                {
                    return false;
                }

            }
            return true;
        
        }
    }
}

