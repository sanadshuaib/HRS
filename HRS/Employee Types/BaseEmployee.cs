using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRS
{
    public abstract class BaseEmployee : IBaseEmployee
    {
        public int ID { get; set; }// Employee ID
        public string Name { get; set; }// Employee Name
        public int Age { get; set; }// Employee Age

        /// <summary>
        /// Prints details of the employee file
        /// </summary>
        /// <param name="employee">The employee to which the file will be printed</param>
        public void PrintFile(IBaseEmployee employee)
        {
            Console.WriteLine($"{employee.GetType().Name} File : \nID:{employee.ID}\nName:{employee.Name}\nAge:{employee.Age}");
        }
    }
}
