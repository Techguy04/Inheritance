using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
   public class SchoolTM
    {
        public string title;
        public string firstname;
        public string lastname;

        //constructor
        public SchoolTM(string title, string firstname, string lastname)
        {
            this.title = title;
            this.firstname = firstname;
            this.lastname = lastname;
        }   
    }

    //Teacher's Profile
    public class teacher : SchoolTM
    {
        public int id;
        public string department;
        public double salary;

        //Teachers Constructor
        public teacher(int id, string title,
            string firstname, string lastname,
            string department, double salary) : base(title, firstname, lastname)
        {
            this.id = id;
            this.department = department;
            this.salary = salary;
        }

        //Teacher's Details Output
        public void TeacherDetails()
        {
            Console.WriteLine(" \n\n  =============================================");
            Console.WriteLine("                  Teacher's Details");
            Console.WriteLine(" =============================================");
            Console.WriteLine("ID: {0}", id);
            Console.WriteLine("Name: {0} {1} {2}", title, firstname, lastname);
            Console.WriteLine("Department: {0}", department);
            Console.WriteLine("Salary: {0}", salary);
        }
    }

    //Student Profile
    public class student : SchoolTM
    {
        public int id;
        public int age;
        public string studclass;
        public string subject;
       

        //Student Constructor
        public student(
            int id, string title, 
            string firstname, string lastname, 
            int age, string studclass, string subject) : base(title, firstname, lastname)
        {
            this.id = id;
            this.age = age;
            this.studclass = studclass;
            this.subject = subject;
            
        }

        //Student Output
        public void StudentDetails()
        {
            Console.WriteLine("\n\n===========================");
            Console.WriteLine("     Student's Details     ");
            Console.WriteLine("===========================");
            Console.WriteLine("Student ID: {0}", id);
            Console.WriteLine("Student Name: {0} {1} {2}",title, firstname, lastname);
            Console.WriteLine("Student Age: {0}", age);
            Console.WriteLine("Student Class: {0}", studclass);
            Console.WriteLine("Student Subject: {0}", subject);
        }
    }

    //Parents Profile
    public class parents : SchoolTM
    {
        public int id;
        public int noOfChild;

        //parents constructor
        public parents(
            int id, string title,
            string firstname, string lastname, 
            int noOfChild) : base(title, firstname, lastname)
        {
            this.id=id;
            this.noOfChild=noOfChild;
        }
            
        //parents output
        public  void ParentDetails()
        {
            Console.WriteLine(" \n\n =========================");
            Console.WriteLine("    Parent's Details      ");
            Console.WriteLine(" =========================");
            Console.WriteLine("Parent ID: {0}", id);
            Console.WriteLine("Parent's Name: {0} {1} {2}", title, firstname, lastname);
            Console.WriteLine("No. Of Child: {0}", noOfChild);
        }
    }
}
