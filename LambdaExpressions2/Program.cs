using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpressions2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creating a new object which is a list of employees, in the employee class, which is named listEmployee 

            List<Employee> listEmployees = new List<Employee>()
            {
                new Employee {ID = 101, Name = "Melissa"},
                new Employee {ID = 102, Name = "Chris"},
                new Employee {ID = 103, Name = "William" },
                new Employee { ID = 104, Name = "Stephen" },
                new Employee { ID = 105, Name = "Brad" },
                new Employee { ID = 106, Name = "Merick" },
                new Employee { ID = 107, Name = "Kurt" },
                new Employee { ID = 108, Name = "Moe" },
            };

            Employee myEmployee = listEmployees.Find(Emp => Emp.ID == 105); //Emp short for Employee type/class

            Console.WriteLine("The employee's name is {0} and the employee ID is {1}", myEmployee.Name, myEmployee.ID);
            Console.ReadKey();


            //Below I just added the type in front of Emp to show that it is another way to get the same result.  

            Employee myEmployee2 = listEmployees.Find((Employee Emp) => Emp.ID == 103); 

            Console.WriteLine("The employee's name is {0} and the employee ID is {1}", myEmployee2.Name, myEmployee2.ID);
            Console.ReadKey();



            int count = listEmployees.Count((Employee x) => x.Name.StartsWith("M"));
            Console.WriteLine("I have " +count+ " employees whose first names start with the letter M.");
            Console.ReadKey();

            //Printing the same thing with $ and a placeholder instead of concatenation
            Console.WriteLine($"I have {count} employees whose first names start with the letter M.", listEmployees.Count);
            Console.ReadKey();

        }
    }

    //New Employee class (aka type) below

    public class Employee
    {

        //Properties
        public int ID { get; set; }
        public string Name { get; set; }


        //Constructor
        public Employee()
        {

        }

    }

}
