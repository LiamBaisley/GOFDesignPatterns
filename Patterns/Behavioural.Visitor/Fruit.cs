using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioural.Visitor
{
    internal class Fruit: IShoppingItem
    {
        public int Price { get; set; }
        public string SKU { get; set; }

        public Fruit(int cost, string sku)
        {
            this.Price = cost;
            this.SKU = sku;
        }
        public int accept(ShoppingCartVisitor visitor)
        {
            return visitor.visit(this);
        }
    }
}
