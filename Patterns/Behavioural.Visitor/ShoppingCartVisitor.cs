using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioural.Visitor
{
    internal class ShoppingCartVisitor: IShoppingCartVisitor
    {
        public int visit(Fruit fruit)
        {
            int cost = fruit.Price;
            Console.WriteLine($"{fruit.SKU} costs {cost}");
            return cost;
        }

        public int visit(Bread bread)
        {
            int cost = bread.Price;
            Console.WriteLine($"{bread.SKU} costs {cost}");
            return cost;
        }
    }
}
