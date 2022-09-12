using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural.Flyweight
{
    internal class PartTimeEmployee: IEmployeeTax
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
        public PartTimeEmployee()
        {
            EmployeeType = "PartTime";
            TaxBracket = 2;
        }
        public void DisplayTaxBracket()
        {
            Console.WriteLine($"The Tax Bracket is {TaxBracket}");
        }
    }
}
