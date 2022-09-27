using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioural.Visitor
{
    internal interface IShoppingCartVisitor
    {
        int visit(Fruit fruit);
        int visit(Bread bread);
    }
}
