using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeData
{
    class EmployeeData
    {
        static void Main(string[] args)
        {
            string name = "Amanda";
            string lastName = "Jonson";
            int age = 27;
            char gender = 'f';
            long id = 8306112507;
            int employeeNumber = 27563571;

            Console.WriteLine($"First name: {name}");
            Console.WriteLine($"Last name: {lastName}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Gender: {gender}");
            Console.WriteLine($"Personal ID: {id}");
            Console.WriteLine($"Unique Employee number: {employeeNumber}");
        }
    }
}
