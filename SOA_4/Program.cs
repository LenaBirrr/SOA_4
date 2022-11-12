// See https://aka.ms/new-console-template for more information
using SOA_4;

List<PrimarySchoolStudent> students = new List<PrimarySchoolStudent>();
students.Add(new FirstGradeStudent(1));
students.Add(new PrimarySchoolStudent(2));
students.Add(new PrimarySchoolStudent(3));
foreach (var student in students)
    student.TryHaveLunch(3);
Console.WriteLine("Hello, World!");
