using System;

namespace Student
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string groupNo;

            do
            {
                Console.WriteLine("GroupNo Daxil Edin");


                groupNo = Console.ReadLine();
            } while (CheckGroupNo(groupNo) == false);

            Student Studentt = new Student
            {
                GroupNo = groupNo,
            };


            static bool CheckGroupNo(string str)
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
}




