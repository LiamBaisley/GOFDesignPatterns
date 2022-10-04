using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioural.Momento
{
    internal class Momento
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public double Budget { get; set; }

        public Momento(string name, string phone, double budget)
        {
            this.Name = name;
            this.Phone = phone;
            this.Budget = budget;
        }
    }
}
