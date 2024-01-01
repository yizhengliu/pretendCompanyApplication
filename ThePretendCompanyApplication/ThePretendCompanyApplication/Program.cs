using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices.WindowsRuntime;
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
            //var results = from dept in departmentList
            //              join emp in employeeList
            //              on dept.Id equals emp.DepartmentId
            //              into employeeGroup
            //              select new
            //              { 
            //                    Employees = employeeGroup,
            //                  DepartmentName = dept.LongName
            //              };
            //foreach (var item in results)
            //{
            //    //although there is no employee in a department, the item still exists
            //    Console.WriteLine($"Department Name: {item.DepartmentName}");
            //    foreach (var emp in item.Employees)
            //        Console.WriteLine($"\t{emp.FirstName} {emp.LastName}");
            //}
            //more linq operation
            //LinqOperation();
            additionalOperation();
            Console.ReadKey();
        }

        private static void additionalOperation() 
        {

            List<Employee> employeeList = Data.GetEmployees();
            List<Department> departmentList = Data.GetDepartments(employeeList);

            //it compares values and the order, we need our own compareer for complex user defined data type
            //var employeeCompare = Data.GetEmployees();
            //bool boolSE = employeeList.SequenceEqual(employeeCompare, new EmployeeComparer());

            //Console.WriteLine(boolSE);


            //List<int> integerList1 = new List<int> { 1, 2, 3, 4};
            //List<int> integerList2 = new List<int> { 5, 6, 7, 8, 9, 10 };
            //IEnumerable<int> integerListConcat = integerList1.Concat(integerList2);

            //concat will append items to the original one
            //List<Employee> employeeList2 = new List<Employee> { new Employee { Id = 5, FirstName = "Tony", LastName = "some", AnnualSalary = 20000, IsManager = false, DepartmentId = 2 } };

            //IEnumerable<Employee> concat = employeeList.Concat(employeeList2);
            //foreach (var emp in concat) 
            //{
            //    Console.WriteLine($"\t{emp.FirstName} {emp.LastName}");
            //}

            //Aggregate custom operation, where we can define our own lambda function
            //decimal totalAnnualSalary = employeeList.Aggregate<Employee, decimal>(0, (totAnnualSalary, e) => 
            //{
            //    var bonus = (e.IsManager) ? 0.04m : 0.02m;
            //    totAnnualSalary += (e.AnnualSalary + (e.AnnualSalary * bonus));
            //    return totAnnualSalary;
            //});

            //string data = employeeList.Aggregate<Employee, string, string>("Employee Annual Salaries (including bonus):",
            //    (resultStr, e) => 
            //    {
            //        var bonus = (e.IsManager) ? 0.04m : 0.02m;
            //        var totAnnualSalary = (e.AnnualSalary + (e.AnnualSalary * bonus));
            //        return resultStr += $"{e.FirstName} {e.LastName} - {totAnnualSalary},";
            //    }, s => s.Substring(0, s.Length - 1));

            //Console.WriteLine(data);
            //average

            //decimal average = employeeList.Where(e => e.DepartmentId == 3).Average(e => e.AnnualSalary);
            //Console.WriteLine($"Average Anuual Salary: {average}");

            //count, how many items
            //int countEmployees = employeeList.Where(e => e.DepartmentId == 3).Count();
            //Console.WriteLine($"nbumber of emplyeess {countEmployees}");

            //sum
            //decimal sum = employeeList.Sum(e => e.AnnualSalary);
            //Console.WriteLine($"total salary, {sum}");

            //Max
            //decimal max = employeeList.Max(e => e.AnnualSalary);

            //Console.WriteLine($"highest salary, {max}");

            //Default if empty, return default value as the first element if it is empty
            //List<int> intList = new List<int>();
            //var newList = intList.DefaultIfEmpty(999999);// we can also customise our default value
            //Console.WriteLine(newList.ElementAt(0));
            //List<Employee> employees = new List<Employee>();
            //var newList = employees.DefaultIfEmpty(new Employee { Id = 0});
            //var result = newList.ElementAt(0);
            //if(result.Id == 0)
            //Console.WriteLine("The list is empty");
            //empty
            //IEnumerable<Employee> emptyEmployeeList = Enumerable.Empty<Employee>();
            //List<Employee> employeesE = Enumerable.Empty<Employee>().ToList();
            //employeesE.Add(new Employee { Id = 5, FirstName = "Tony", LastName = "some", AnnualSalary = 20000, IsManager = false, DepartmentId = 2 });
            //foreach (var e in employeesE) 
            //{
            //    Console.WriteLine($"{e.FirstName} {e.LastName} - {e.AnnualSalary}");
            //}
            //range, initial value of 25 and increase by one for others add up to all 20 elements
            //var intCollection = Enumerable.Range(25, 20);
            //foreach (var item in intCollection) 
            //{
            //    Console.WriteLine(item);
            //}

            //repeat, with repeating element of specfic times
            //var strCollection = Enumerable.Repeat<string>("Placeholder", 10);
            //foreach (var item in strCollection) 
            //{
            //    Console.WriteLine(item);
            //}

            //distinct- return distinct elements in the collection
            //List<int> list = new List<int> { 1, 2, 1, 4, 6, 2, 6, 7, 8, 7, 7, 7 };
            //var result = list.Distinct();
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            //except - return the element that does not appear in the second collection
            //IEnumerable<int> collection1 = new List<int> { 1, 2, 3, 4 };
            //IEnumerable<int> collection2 = new List<int> { 3, 4, 5, 6 };
            //var result = collection1.Except(collection2);
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            //List<Employee> employeeList2 = new List<Employee>();
            //employeeList2.Add(new Employee
            //{
            //    Id = 3,
            //    FirstName = "Douglas",
            //    LastName = "Roberts",
            //    AnnualSalary = 40000.2m,
            //    IsManager = false,
            //    DepartmentId = 2
            //});
            //employeeList2.Add(new Employee
            //{
            //    Id = 5,
            //    FirstName = "yi",
            //    LastName = "z",
            //    AnnualSalary = 5000.2m,
            //    IsManager = false,
            //    DepartmentId = 2
            //});

            ////var result = employeeList.Except(employeeList2, new EmployeeComparer());
            ////foreach (var e in result)
            ////{
            ////    Console.WriteLine($"{ e.FirstName}{ e.LastName} - { e.AnnualSalary}");
            ////}

            ////intersect-- same elements
            ////var result = employeeList.Intersect(employeeList2, new EmployeeComparer());
            ////union
            //var result = employeeList.Union(employeeList2, new EmployeeComparer());
            //foreach (var e in result)
            //{
            //    Console.WriteLine($"{e.FirstName}{e.LastName} - {e.AnnualSalary}");
            //} 

            //skip, skip over a certain number of elements and return reminder
            //var result = employeeList.Skip(2);
            //foreach (var e in result)
            //{
            //    Console.WriteLine($"{e.FirstName}{e.LastName} - {e.AnnualSalary}");
            //}

            //skip while, once the condition return false, return the reminder
            //var result = employeeList.SkipWhile(e => e.AnnualSalary > 50000);
            //foreach (var e in result)
            //{
            //    Console.WriteLine($"{e.FirstName}{e.LastName} - {e.AnnualSalary}");
            //}

            //take the first certain number of elements
            //var result = employeeList.Take(2);
            //foreach (var e in result)
            //{
            //    Console.WriteLine($"{e.FirstName}{e.LastName} - {e.AnnualSalary}");
            //}

            //take while, take all elements that is true and then skip other elements once false is returned
            //var result = employeeList.TakeWhile(e => e.AnnualSalary > 50000);
            //foreach (var e in result)
            //{
            //    Console.WriteLine($"{e.FirstName}{e.LastName} - {e.AnnualSalary}");
            //}

            //tolist, immediately
            //List<Employee> results = (from emp in employeeList
            //                         where emp.AnnualSalary > 50000
            //                         select emp).ToList();

            //foreach (var e in results)
            //{
            //    Console.WriteLine($"{e.FirstName}{e.LastName} - {e.AnnualSalary}");
            //}

            //todictionary
            //Dictionary<int, Employee> results = (from emp in employeeList
            //                                    where emp.AnnualSalary > 50000
            //                                    select emp).ToDictionary<Employee, int>(e => e.Id);

            //foreach (var key in results.Keys) 
            //{
            //    Console.WriteLine(($"Key: {key}, Value: {results[key].FirstName}{results[key].LastName} - {results[key].AnnualSalary}"));
            //}


            //toarray

            //List<Employee> results = (from emp in employeeList
            //                         where emp.AnnualSalary > 50000
            //                         select emp).ToList();

            //foreach (var e in results)
            //{
            //    Console.WriteLine($"{e.FirstName}{e.LastName} - {e.AnnualSalary}");
            //}

            //let and into
            //let can be used to create additional attributes using predefined attributes for further usage
            //var results = from emp in employeeList
            //             let Initials = emp.FirstName.Substring(0, 1).ToUpper() + emp.LastName.Substring(0, 1).ToUpper()
            //             let AnnualSalaryPlusBonus = (emp.IsManager) ? emp.AnnualSalary * (1.04m) : emp.AnnualSalary * (1.02m)
            //             where Initials == "JS" || Initials == "SJ" && AnnualSalaryPlusBonus > 50000
            //             select new
            //             {
            //                 Initials = Initials,
            //                 FullName = emp.FirstName + " " + emp.LastName,
            //                 AnnualSalaryPlusBonus = AnnualSalaryPlusBonus
            //             };
            //foreach (var e in results)
            //{
            //    Console.WriteLine($"{e.Initials}{e.FullName} - {e.AnnualSalaryPlusBonus}");
            //}

            //into- create new group from conditions for further filtering

            //var results = from emp in employeeList
            //             where emp.AnnualSalary > 50000
            //             select emp
            //             into HighEarners
            //             where HighEarners.IsManager
            //             select HighEarners;

            //foreach (var e in results)
            //{
            //    Console.WriteLine($"{e.FirstName}{e.LastName} - {e.AnnualSalary}");
            //}

            //select 
            //var results = departmentList.Select(d => d.Employees);

            //foreach (var items in results)
            //    foreach (var item in items) 
            //    {
            //        Console.WriteLine($"{item.FirstName}{item.LastName} - {item.AnnualSalary}");
            //    }

            //select many, if we have one to many relationship, we can use selectmany to avoid nested loop
            var results = departmentList.SelectMany(d => d.Employees);

            foreach (var item in results)
                {
                    Console.WriteLine($"{item.FirstName}{item.LastName} - {item.AnnualSalary}");
                }

        }

        private static void LinqOperation() 
        {
            List<Employee> employeeList = Data.GetEmployees();
            List<Department> departmentList = Data.GetDepartments(employeeList);
            //sorting operation, orderby, orderbydesending, thenby thenbydesending
            //Method syntax
            //var result = employeeList.Join(departmentList, 
            //    e => e.DepartmentId, 
            //    dept => dept.Id,
            //    (employee, department) => new 
            //    {
            //        Id = employee.Id,
            //        FirstName = employee.FirstName,
            //        LastName = employee.LastName,
            //        AnnualSalary = employee.AnnualSalary,
            //        DepartmentId = employee.DepartmentId,
            //        DepartmentName = department.LongName
            //    }).OrderBy(o => o.DepartmentId).ThenByDescending(o=>o.AnnualSalary);

            //foreach (var item in result) 
            //{
            //    Console.WriteLine($"Id: {item.Id, -5} First Name: {item.FirstName, -10}, Last Name: {item.LastName, -10}, Annual Salary: {item.AnnualSalary, 10}\tDepartment Name: {item.DepartmentName}");
            //}

            //query syntax
            //var result = from employee in employeeList
            //             join department in departmentList
            //             on employee.DepartmentId equals department.Id
            //             orderby employee.DepartmentId, employee.AnnualSalary descending
            //             select new 
            //             {
            //                 Id = employee.Id,
            //                 FirstName = employee.FirstName,
            //                 LastName = employee.LastName,
            //                 AnnualSalary = employee.AnnualSalary,
            //                 DepartmentId = employee.DepartmentId,
            //                 DepartmentName = department.LongName
            //             };

            //Group Operators
            //groupBy- deferred
            //var result = from emp in employeeList
            //             orderby emp.DepartmentId
            //             group emp by emp.DepartmentId;

            //foreach (var empGroup in result) 
            //{
            //    Console.WriteLine($"Department Id: {empGroup.Key}");
            //    foreach (var item in empGroup)
            //    {
            //        Console.WriteLine($"Id: {item.Id,-5} First Name: {item.FirstName,-10}, Last Name: {item.LastName,-10}, Annual Salary: {item.AnnualSalary,10}");
            //    }
            //}
            //to look up -immediately
            //var result = employeeList.OrderBy(e => e.DepartmentId).ToLookup(e => e.DepartmentId);
            //foreach (var empGroup in result)
            //{
            //    Console.WriteLine($"Department Id: {empGroup.Key}");
            //    foreach (var item in empGroup)
            //    {
            //        Console.WriteLine($"Id: {item.Id,-5} First Name: {item.FirstName,-10}, Last Name: {item.LastName,-10}, Annual Salary: {item.AnnualSalary,10}");
            //    }
            //}

            //all any contains quantifier
            //var annualSalaryCompare = 40000;
            //bool isTrueAll = employeeList.All(e => e.AnnualSalary > annualSalaryCompare);
            //if(isTrueAll)
            //    Console.WriteLine($"All employee annual salaries are above {annualSalaryCompare}");
            //else
            //    Console.WriteLine($"Not all employee annual salaries are above {annualSalaryCompare}");

            //bool isTrueAny = employeeList.Any(e => e.AnnualSalary > annualSalaryCompare);
            //if (isTrueAny)
            //    Console.WriteLine($"At least one employee has an annual salaries above {annualSalaryCompare}");
            //else
            //    Console.WriteLine($"No employee annual have a salary above {annualSalaryCompare}");

            //contains operator
            //var searchEmployee = new Employee
            //{
            //    Id = 3,
            //    FirstName = "Douglas",
            //    LastName = "Roberts",
            //    AnnualSalary = 40000.2m,
            //    IsManager = false,
            //    DepartmentId = 2
            //};

            //bool containsEmployee = employeeList.Contains(searchEmployee, new EmployeeComparer());
            //// we need to tell compiler how to compare employee object using a new class implements IEuqalitycompaer interface

            //if (containsEmployee)
            //{
            //    Console.WriteLine($"An employee record for {searchEmployee.FirstName} {searchEmployee.LastName} was found");
            //}
            //else 
            //{
            //    Console.WriteLine($"An employee record for {searchEmployee.FirstName} {searchEmployee.LastName} was not found");
            //}

            //ofType filter operator
            ArrayList mixedCollection = GetHeterogeneousDataCollection();
            //var stringResult = from s in mixedCollection.OfType<string>()
            //                   select s;

            //var intResult = from i in mixedCollection.OfType<int>()
            //                select i;

            //var employeeResult = from e in mixedCollection.OfType<Employee>()
            //                     select e;
            //var departmentResult = from d in mixedCollection.OfType<Department>()
            //                       select d;
            //foreach(var dept in departmentResult)
            //    Console.WriteLine($"{dept.Id,-5} {dept.ShortName, -20} {dept.LongName, -10}");

            //elementat, elementAtOrDefault, First, Last, Single and Single or default
            //var employee = employeeList.ElementAtOrDefault(12);
            //if (employee != null)
            //    Console.WriteLine($"Id: {employee.Id,-5} First Name: {employee.FirstName,-10}, Last Name: {employee.LastName,-10}, Annual Salary: {employee.AnnualSalary,10}");
            //else 
            //{
            //    Console.WriteLine("This employee record does not exist within the collection");
            //}

            //first last, single
            //List<int> integerList = new List<int> { 3, 13, 23, 17, 29, 89 };
            //int result = integerList.FirstOrDefault(i => i % 2 == 0);
            //result = integerList.Single(e => e== 3);
            //if (result != 0)
            //{

            //    Console.WriteLine(result);
            //}
            //else 
            //{
            //    Console.WriteLine("There are no even numbers in the collection");
            //}
        }

        public static ArrayList GetHeterogeneousDataCollection()
        {
            ArrayList arrayList = new ArrayList();
            arrayList.Add(100);
            arrayList.Add("Bob Jones");
            arrayList.Add(2000);
            arrayList.Add(3000);
            arrayList.Add("Bill Henderson");
            arrayList.Add(new Employee { Id = 6, FirstName = "Jennifer", LastName = "Dale", AnnualSalary = 90000, IsManager = true, DepartmentId = 1 });
            arrayList.Add(new Employee { Id = 7, FirstName = "Dane", LastName = "Hughes", AnnualSalary = 60000, IsManager = false, DepartmentId = 2 }); ;
            arrayList.Add(new Department { Id = 4, ShortName = "MKT", LongName = "Marketing" });
            arrayList.Add(new Department { Id = 5, ShortName = "R&D", LongName = "Research and Developement" });
            arrayList.Add(new Department { Id = 6, ShortName = "PRD", LongName = "Production" });

            return arrayList;

        }
    }
    public class EmployeeComparer : IEqualityComparer<Employee>
    {
        public bool Equals(Employee x, Employee y)
        {
            if(x.Id == y.Id && x.FirstName.ToLower() == y.FirstName.ToLower() && x.LastName.ToLower() == y.LastName.ToLower())
                return true;
            return false;
        }

        public int GetHashCode(Employee obj)
        {
            return obj.Id.GetHashCode();
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
