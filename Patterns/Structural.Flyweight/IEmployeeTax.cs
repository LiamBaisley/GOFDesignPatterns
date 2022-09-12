using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural.Flyweight
{
    internal interface IEmployeeTax
    {
        string EmployeeType
        {
            get;
            set;
        }
        int TaxBracket
        {
            get;
            set;
        }
        void DisplayTaxBracket();
    }
}
