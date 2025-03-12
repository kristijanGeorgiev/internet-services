// See https://aka.ms/new-console-template for more information
#region Inheritence
using PersonInheritence.Inheritence;

Student student = new Student("Kristijan");
Console.WriteLine(student.ToString());
student.StudyMethod();
Teacher teacher = new Teacher("Monika");
Console.WriteLine(teacher.ToString());
teacher.ExplainMethod();
#endregion
