using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week4ora2
{
    public class PizzaTopping
    {
        private ToppingNames  _name;

        private Dictionary<ToppingNames, decimal> prices;
        public PizzaTopping()
        {
            prices = new Dictionary<ToppingNames, decimal>
            {
                { ToppingNames.Cheese ,20},
                { ToppingNames.Meat ,30},
                { ToppingNames.Vegetable ,40}
            };
            
        }
        public ToppingNames Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (value == ToppingNames.Cheese ||
                    value == ToppingNames.Meat ||
                    value == ToppingNames.Vegetable)

                { _name = value; }
                else
                {
                    Console.WriteLine("Introduceti valoare corecta pt topping");
                }

            }
        }
       // private decimal _cost;
        public decimal Cost 
        { get
            {
                return { prices[this.Name]};
            }
                /* switch(Name)
                  {
                      case ToppingNames.Cheese:
                      return 15;

                      case ToppingNames.Meat:
                          return 20;
                      case ToppingNames.Vegetable:
                          return 30;
                      default:
                          return 30;
                  }*/

            

         // private set
           // {
              // _cost=value;
           // }
        }

         public void Print()
        {
            if (Name == ToppingNames.Meat)
            {
                Console.WriteLine(($"{this.Name.ToString().ToString()} - {this.Cost}"));
            }
            else
            { 
                Console.WriteLine($"{this.Name} - {this.Cost}");
            }
            
        }

    }
    
}