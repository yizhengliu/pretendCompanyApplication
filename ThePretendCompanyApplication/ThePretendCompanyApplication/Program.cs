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
            List<Employee> employeeList = Data.GetEmployees();
            List<Department> departmentList = Data.GetDepartments();
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
            /*
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
            */



            // Select and Where Operators - Method Syntax
            //var results = employeeList.Select(e => new 
            //{
            //    FullName = e.FirstName + " " + e.LastName,
            //    AnnualSalary = e.AnnualSalary
            //}).Where(e => e.AnnualSalary >= 50000);

            //employeeList.Add(new Employee
            //{
            //    Id= 5,
            //    FirstName = "Sam",
            //    LastName = "Davis",
            //    AnnualSalary = 100000.20m,
            //    IsManager = true,
            //    DepartmentId = 2
            //});
            //foreach (var item in results) 
            //{
            //    Console.WriteLine($"{item.FullName, -20} {item.AnnualSalary, 10}");
            //}


            // Select and Where Operators - Query Syntax with deferred
            //var results = from emp in employeeList
            //              where emp.AnnualSalary >= 50000
            //             select new
            //             {
            //                 FullName = emp.FirstName + " " + emp.LastName,
            //                 AnnualSalary = emp.AnnualSalary
            //             };

            //employeeList.Add(new Employee
            //{
            //    Id= 5,
            //    FirstName = "Sam",
            //    LastName = "Davis",
            //    AnnualSalary = 100000.20m,
            //    IsManager = true,
            //    DepartmentId = 2
            //});

            ////deferred execution, the results only evaluates when the attributes are used
            //foreach (var item in results)
            //{
            //    Console.WriteLine($"{item.FullName,-20} {item.AnnualSalary,10}");
            //}

            //deferred execution, the results only evaluates when the attributes are used
            //var results = from emp in employeeList.GetHighSalariedEmployees()
            //              select new
            //              {
            //                  FullName = emp.FirstName + " " + emp.LastName,
            //                  AnnualSalary = emp.AnnualSalary
            //              };
            //employeeList.Add(new Employee
            //{
            //    Id = 5,
            //    FirstName = "Sam",
            //    LastName = "Davis",
            //    AnnualSalary = 100000.20m,
            //    IsManager = true,
            //    DepartmentId = 2
            //});

            //foreach (var item in results)
            //{
            //    Console.WriteLine($"{item.FullName,-20} {item.AnnualSalary,10}");
            //}

            //var results = (from emp in employeeList.GetHighSalariedEmployees()
            //               select new
            //               {
            //                   FullName = emp.FirstName + " " + emp.LastName,
            //                   AnnualSalary = emp.AnnualSalary
            //               }).ToList();
            //employeeList.Add(new Employee
            //{
            //    Id = 5,
            //    FirstName = "Sam",
            //    LastName = "Davis",
            //    AnnualSalary = 100000.20m,
            //    IsManager = true,
            //    DepartmentId = 2
            //});

            //foreach (var item in results)
            //{
            //    Console.WriteLine($"{item.FullName,-20} {item.AnnualSalary,10}");
            //}
            //lazy evaluation

            //Join operation - method syntax
            //var results = departmentList.Join(employeeList,
            //    department => department.Id,
            //    employee => employee.DepartmentId,
            //    (department, employee) => new
            //    {
            //        FullName = employee.FirstName + " " + employee.LastName,
            //        AnnualSalary = employee.AnnualSalary,
            //        departmentName = department.LongName
            //    });

            //foreach (var item in results)
            //{
            //    Console.WriteLine($"{item.FullName,-20} {item.AnnualSalary,10}\t{item.departmentName,20}");
            //}

            //join operation - query syntax, inner join
            //var results = from department in departmentList
            //              join employee in employeeList
            //              on department.Id equals employee.DepartmentId
            //              select new 
            //              {
            //                  FullName = employee.FirstName + " " + employee.LastName,
            //                  AnnualSalary = employee.AnnualSalary,
            //                  DepartmentName = department.LongName
            //              };

            //foreach (var item in results)
            //{
            //    Console.WriteLine($"{item.FullName,-20} {item.AnnualSalary,10}\t{item.DepartmentName,20}");
            //}

            //join operation - method syntax, outter left join
            //var results = departmentList.GroupJoin(employeeList,
            //        dept => dept.Id,
            //        emp => emp.DepartmentId,
            //        (dept, employeeGroup) => new
            //        {
            //            Employees = employeeGroup,
            //            DepartmentName = dept.LongName
            //        }
            //    );
            //foreach (var item in results)
            //{
            //    //although there is no employee in a department, the item still exists
            //    Console.WriteLine($"Department Name: {item.DepartmentName}");
            //    foreach (var emp in item.Employees)
            //        Console.WriteLine($"\t{emp.FirstName} {emp.LastName}");
            //}
            //join operation - query syntax, outter left join, only into is added 
            var results = from dept in departmentList
                          join emp in employeeList
                          on dept.Id equals emp.DepartmentId
                          into employeeGroup
                          select new
                          { 
                                Employees = employeeGroup,
                              DepartmentName = dept.LongName
                          };
            foreach (var item in results)
            {
                //although there is no employee in a department, the item still exists
                Console.WriteLine($"Department Name: {item.DepartmentName}");
                foreach (var emp in item.Employees)
                    Console.WriteLine($"\t{emp.FirstName} {emp.LastName}");
            }
            Console.ReadKey();
        }

        
    }
    public static class EnumerableCollectionExtensionMethods
    {
        public static IEnumerable<Employee> GetHighSalariedEmployees(this IEnumerable<Employee> employees)
        {
            foreach (Employee emp in employees)
            {
                Console.WriteLine($"Accessing employee: {emp.FirstName + " " + emp.LastName}");
                if (emp.AnnualSalary >= 50000)
                    yield return emp;
                //using yield return to return each element one at a time
            }
        }
    }
}
