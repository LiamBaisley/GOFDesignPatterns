using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioural.TemplateMethod
{
    internal class HTMLDocument: AbstractDocument
    {
        public override void PrintHeader()
        {
            Console.WriteLine("This is the HTML document header");
        }

        public override void PrintBody()
        {
            Console.WriteLine("This is the HTML Body");
        }

        public override void PrintFooter()
        {
            Console.WriteLine("This is the HTML footer");
        }
    }
}
