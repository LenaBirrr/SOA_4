using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOA_4
{
    public class Student
    {
        public int StudentId { get; set; }
        public Student(int studentId)
        {
            StudentId = studentId;
        }
        public bool TryHaveLunch(int numberOfBreak)
         {
             if(numberOfBreak>1&& numberOfBreak<5)
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

