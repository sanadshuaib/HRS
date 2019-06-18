using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRS
{
    /// <summary>
    /// Type that represents a sample encapsulated functionality of the 
    /// Accounting department and can be extended later as needed
    /// </summary>
    public class AccountingDepartment
    {
        decimal salary = 0; 
        Dictionary<Type, Action> @switch;

        public AccountingDepartment()
        {
            @switch = new Dictionary<Type, Action>();
            @switch.Add(new Employee().GetType(), () => salary = 50000 * 2);
            @switch.Add(new Manager().GetType(), () => salary = 50000 * 4);
            @switch.Add(new CEO().GetType(), () => salary = 50000 * 6);
            @switch.Add(new Anonymous().GetType(), () => salary = 0);
        }

        /// <summary>
        /// Calculates the salary of an employee based on the type 
        /// passed
        /// </summary>
        /// <param name="employee">The employee to calculate the salary for</param>
        public void CalcSalary(IBaseEmployee employee)
        {
            @switch[employee.GetType()].Invoke();
            Console.WriteLine($"The salary is : {this.salary}");
        }
    }
}
