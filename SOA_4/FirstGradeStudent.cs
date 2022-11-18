using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOA_4
{
    public class FirstGradeStudent:IStudent
    {
        public FirstGradeStudent(int studentId)
        {
            StudentId = studentId;
        }

        public int StudentId { get; set; }

        public bool TryHaveLunch(int numberOfBreak)
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
