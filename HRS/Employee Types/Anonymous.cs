using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRS
{
    /// <summary>
    /// Anonymous type for unknown employees
    /// </summary>
    public class Anonymous:BaseEmployee
    {
        // init ...
        public Anonymous()
        {
            this.ID = -1;
            this.Name = "Anonymous";
            this.Age = -1;
        }
    }
}
