// See https://aka.ms/new-console-template for more information
using SOA_4;

List<IStudent> students = new List<IStudent>();
students.Add(new FirstGradeStudent(1));
students.Add(new PrimarySchoolStudent(2));
students.Add(new PrimarySchoolStudent(3));
foreach (var student in students)
    student.TryHaveLunch(3);

int feed = 0;
foreach (var student in students)
{
    if (student.TryHaveLunch(3))
        feed++;
}

if (students.Count != feed)
{
    Console.WriteLine($"Satisfied students:{feed}");
    Console.WriteLine($"Fed students:{students.Count}");

}
