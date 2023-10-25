using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex7
{
    class InvalidEmpidException : Exception
    {
        public InvalidEmpidException(string msg) : base(msg) { }
    }
    class InvalidNameException : Exception
    {
        public InvalidNameException(string msg) : base(msg) { }
    }
    class InvalidAgeException:Exception
    {
        public InvalidAgeException(string msg) : base(msg) { }
    }
    class Employee
    {
        string empid,name;
        int age;
        public Employee(string empid, string name, int age)
        {
            if (empid.Length < 4) throw new InvalidEmpidException("Length of the Empid should be greater than 4");
            if (int.TryParse(name, out int result)) throw new InvalidNameException("Name Should not be a number");
            if (age > 50) throw new InvalidAgeException("Age should not be less than or equal to 50");
            this.empid = empid;
            this.name = name;
            this.age = age;
        }
    }
    internal class SetB
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Employee Id: ");
            string eid=Console.ReadLine();
            Console.Write("Enter Employee Name: ");
            string ename = Console.ReadLine();
            Console.Write("Enter Employee Age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            try
            {
                Employee emp1 = new Employee(eid, ename, age);
                Console.WriteLine("Employee Object Created Successfully");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadKey();
        }
    }
}
