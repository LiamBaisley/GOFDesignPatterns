using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioural.TemplateMethod
{
    internal class PDFDocument: AbstractDocument
    {
        public override void PrintHeader()
        {
            Console.WriteLine("This is the PDF header");
        }

        public override void PrintBody()
        {
            Console.WriteLine("This is the PDF body");
        }

        public override void PrintFooter()
        {
            Console.WriteLine("This is the PDF footer");
        }
    }
}
