using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TCPData;
using TCPextensions;

namespace ThePretendCompanyApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            List<Employee> employeeList = Data.GetEmployees();
            var filteredEmployees = employeeList.Filter<Employee>(e => e.AnnualSalary < 50000);

            foreach (var employee in filteredEmployees) 
            {
                Console.WriteLine($"First Name: {employee.FirstName}");
                Console.WriteLine($"Last Name: {employee.LastName}");
                Console.WriteLine($"Annual Salary: {employee.AnnualSalary}");
                Console.WriteLine($"Manager: {employee.IsManager}");
                Console.WriteLine();
            }
            */
            List<Department> departmentList = Data.GetDepartments();

            var filteredDepartments = departmentList.Filter<Department>(d => d.Id > 1);

            foreach (var department in filteredDepartments)
            {
                Console.WriteLine($"Id: {department.Id}");
                Console.WriteLine($"Short Name: {department.ShortName}");
                Console.WriteLine($"Long Name: {department.LongName}");
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
