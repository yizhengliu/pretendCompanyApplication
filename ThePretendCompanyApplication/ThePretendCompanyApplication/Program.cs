using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
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
            /*
            List<Department> departmentList = Data.GetDepartments();

            var filteredDepartments = departmentList.Filter<Department>(d => d.Id > 1);

            foreach (var department in filteredDepartments)
            {
                Console.WriteLine($"Id: {department.Id}");
                Console.WriteLine($"Short Name: {department.ShortName}");
                Console.WriteLine($"Long Name: {department.LongName}");
                Console.WriteLine();
            }
            */
            /* linq where which is same to custom filter class
            List<Department> departmentList = Data.GetDepartments();

            var filteredDepartments = departmentList.Where(d => d.ShortName == "TE" || d.ShortName == "HR");


            foreach (var department in filteredDepartments)
            {
                Console.WriteLine($"Id: {department.Id}");
                Console.WriteLine($"Short Name: {department.ShortName}");
                Console.WriteLine($"Long Name: {department.LongName}");
                Console.WriteLine();
            }*/

            List<Employee> employeeList = Data.GetEmployees();
            List<Department> departmentList = Data.GetDepartments();

            //query form
            var resultList = from emp in employeeList
                             join dept in departmentList
                             on emp.DepartmentId equals dept.Id
                             select new
                             {
                                 FirstName = emp.FirstName,
                                 LastName = emp.LastName,
                                 AnnualSalary = emp.AnnualSalary,
                                 Manager = emp.IsManager,
                                 Department = dept.LongName
                             };

            foreach (var employee in resultList)
            {
                Console.WriteLine($"First Name: {employee.FirstName}");
                Console.WriteLine($"Last Name: {employee.LastName}");
                Console.WriteLine($"Annual Salary: {employee.AnnualSalary}");
                Console.WriteLine($"Manager: {employee.Manager}");
                Console.WriteLine($"Manager: {employee.Department}");
                Console.WriteLine();
            }

            var averageAnnualSalary = resultList.Average(a => a.AnnualSalary);

            var highestAnnualSalary = resultList.Max(a => a.AnnualSalary);

            var lowestAnnualSalary = resultList.Min(a => a.AnnualSalary);

            Console.WriteLine($"Average Annual Salary: {averageAnnualSalary}");
            Console.WriteLine($"Highest Annual Salary: {highestAnnualSalary}");
            Console.WriteLine($"Lowest Annual Salary: {lowestAnnualSalary}");

            Console.ReadKey();
        }
    }
}
