using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week4ora2
{
    class Program
    {
        static void Main(string[] args)
        {
            PizzaTopping topping = new PizzaTopping { Name = ToppingNames.Meat };
            topping.Name = ToppingNames.Meat;
            topping.Print();

            PizzaBase pizzaBase = new PizzaBase(BaseNames.Regular);

            pizzaBase.Print();

            var pizza = new Pizza(pizzaBase, "Smile");
            pizza.AddTopping(topping);

            pizza.Print();






        }
    }
}
