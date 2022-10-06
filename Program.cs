using ConsoleApp7;

namespace ConsoleApp7
{
    internal class Program
    {

        static void Main(string[] args)
        {
            teacher teacher = new teacher(01, "Mr", "Wutche", "Chikaome", "Computer Science", 500.00);
            teacher.TeacherDetails();

            student student = new student(01, "Miss", "Firima", "Mercy", 19, "Senior Secondary", "Physics");
            student.StudentDetails();

            parents parents = new parents(03, "Mr/Mrs", "John", "Doe", 5);
            parents.ParentDetails();
        }
        
    }

}