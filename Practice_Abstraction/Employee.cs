using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Abstraction
{
    public abstract class Employee
    {        
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Department { get; set; }

        public abstract void Task();
    }

    class ProjectManager : Employee
    {
        public override void Task()
        {
            Console.WriteLine($"{FirstName} {LastName} is working as a {Department}. I am managing projects.");
        }
    }

    class SoftwareDeveloper : Employee
    {
        public override void Task()
        {
            Console.WriteLine($"{FirstName} {LastName} is working as a {Department}. I am developing software.");
        }
    }

    class SalesRepresentative : Employee
    {
        public override void Task()
        {
            Console.WriteLine($"{FirstName} {LastName} is working as a {Department}. I am handling client sales.");
        }
    }
}
