using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOA_4
{
    public class FirstGradeStudent:Student
    {
        public FirstGradeStudent(int studentId) : base(studentId)
        {
        }

        public override bool TryHaveLunch(int numberOfBreak)
        {
            if (numberOfBreak ==2)
            {
                Console.WriteLine(StudentId.ToString() + " had their lunch");
                return true;
            }
            else
            {
                Console.WriteLine(StudentId.ToString() + " was not able to have their lunch");
                return false;
            }
        }
    }
}
