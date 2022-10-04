using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioural.Momento
{
    internal class SalesProspect
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public double Budget { get; set; }

        public Momento SaveMomento()
        {
            Console.WriteLine("State is being saved ------");
            return new Momento(Name, Phone, Budget);
        }

        public void RestoreMoment(Momento momento)
        {
            Console.WriteLine("State is being restored ------");
            this.Name = momento.Name;
            this.Phone = momento.Phone;
            this.Budget = momento.Budget;
        }
    }
}
