using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural.Flyweight
{
    internal class EmployeeTaxFactory
    {
        private Dictionary<string, IEmployeeTax> _employeesTax = new();
        public IEmployeeTax GetEmployeeTaxBracket(string key)
        {
            IEmployeeTax employeeTax = null;
            if (_employeesTax.ContainsKey(key))
            {
                employeeTax = _employeesTax[key];
            }
            else
            {
                switch (key)
                {
                    case "FullTime":
                        employeeTax = new FullTimeEmployee();
                        break;
                    case "PartTime":
                        employeeTax = new PartTimeEmployee();
                        break;
                }
                _employeesTax.Add(key, employeeTax);
            }
            return employeeTax;
        }
    }
}
