using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRS
{
    class Program
    {
        static void Main(string[] args)
        {
            // (1) Create three instances of different employee types
            IBaseEmployee employee = new Employee() { ID=1,Name="Sanad",Age=35};
            IBaseEmployee manager = new Manager() { ID=2,Name="Ahmed",Age=40};
            IBaseEmployee ceo = new CEO() { ID=3,Name="Hasson",Age=60};

            // (2) Create an instance of the EmployeeBook class and add the three employees to it
            EmployeeBook employeeBook = new EmployeeBook();
            employeeBook.AddBaseEmployee(employee);
            employeeBook.AddBaseEmployee(manager);
            employeeBook.AddBaseEmployee(ceo);

            // (3) Print the size of the EmployeeBook instance
            Console.WriteLine($"Employees Book has ({employeeBook.BookSize}) records.");
            Console.WriteLine($"--------------------------------------------------------");

            // (4) Create an instance of the AccountingDepartment
            AccountingDepartment accountingDepartment = new AccountingDepartment();

            // (5) a) Print employee file.
            //     b) Calculate employee salary and print it.
            employee.PrintFile(employeeBook.GetBaseEmployee(1));
            accountingDepartment.CalcSalary(employeeBook.GetBaseEmployee(1));
            Console.WriteLine($"--------------------------------------------------------");

            manager.PrintFile(employeeBook.GetBaseEmployee(2));
            accountingDepartment.CalcSalary(employeeBook.GetBaseEmployee(2));
            Console.WriteLine($"--------------------------------------------------------");

            ceo.PrintFile(employeeBook.GetBaseEmployee(3));
            accountingDepartment.CalcSalary(employeeBook.GetBaseEmployee(3));
            Console.ReadLine();
        }
    }
}
