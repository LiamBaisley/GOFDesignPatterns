using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioural.Visitor
{
    internal interface IShoppingItem
    {
        public int accept(ShoppingCartVisitor visitor);
    }
}
