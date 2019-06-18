using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRS
{
    /// <summary>
    /// Type that represents a book of employees
    /// </summary>
    public class EmployeeBook
    {
        private List<IBaseEmployee> _employee_list; // List of employees
        public int BookSize { get { return _employee_list.Count; } } // Size of the book

        public EmployeeBook()
        {
            // init ...
            _employee_list = new List<IBaseEmployee>();
        }

        /// <summary>
        /// Adds an employee to the employee list
        /// </summary>
        /// <param name="employee">The employee to be added</param>
        public void AddBaseEmployee(IBaseEmployee employee)
        {
            _employee_list.Add(employee);
        }

        /// <summary>
        /// Returns an employee based on the ID of that employee
        /// </summary>
        /// <param name="ID">The ID of the employee</param>
        /// <returns>IBaseEmployee</returns>
        public IBaseEmployee GetBaseEmployee(int ID)
        {
            return _employee_list.Where(x => x.ID.Equals(ID)).FirstOrDefault()??new Anonymous();
        }

    }
}
