using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural.Flyweight
{
    internal class FullTimeEmployee: IEmployeeTax
    {
        public string EmployeeType
        {
            get;
            set;
        }
        public int TaxBracket
        {
            get;
            set;
        }
        public FullTimeEmployee()
        {
            EmployeeType = "FullTime";
            TaxBracket = 1;
        }
        public void DisplayTaxBracket()
        {
            Console.WriteLine($"The Tax Bracket is {TaxBracket}");
        }
    }
}
