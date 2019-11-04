using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week4ora2
{
    public class PizzaBase
    {
        public PizzaBase()
        public BaseNames Name { get; set; }

        private decimal _baseCost = 8m;

        public decimal Cost
        {
            get
            {
              if(Name==BaseNames.Italian)
                {
                    return 1.5m * _baseCost;
                }
                return _baseCost;
            }
        
        }

        public void Print()
        {
            Console.WriteLine($"Base:{Name}, {Cost}");
        }

    }
}
