using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioural.TemplateMethod
{
    internal abstract class AbstractDocument
    {
        //This is the template method. It is the same for all documents. But the implementation of printing header, body and footer can be changed.
        public void Print()
        {
            PrintHeader();
            PrintBody();
            PrintFooter();
        }
        public abstract void PrintHeader();
        public abstract void PrintBody();
        public abstract void PrintFooter();
    }
}
