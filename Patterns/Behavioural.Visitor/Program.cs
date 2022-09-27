using System.Runtime.CompilerServices;
using Behavioural.Visitor;

IShoppingItem[] shoppingItems = 
    new IShoppingItem[] {new Bread(25, "Bread1"), new Bread(22, "Bread2"), new Fruit(22, "Apples"), new Fruit(26, "Grapes")};

Console.WriteLine($"Total cost = {CalculatePrice(shoppingItems)}");


int CalculatePrice(IShoppingItem[] items)
{
    ShoppingCartVisitor vis = new ShoppingCartVisitor();
    var cost = 0;
    foreach (var item in items)
    {
        cost += item.accept(vis);
    }
    return cost;
}