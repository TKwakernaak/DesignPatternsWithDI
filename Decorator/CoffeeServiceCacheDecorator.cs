using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    public class CoffeeServiceCacheDecorator : CoffeeServiceDecorator
    {

        public CoffeeServiceCacheDecorator(ICoffeeService coffeeService) : base(coffeeService)
        {

        }

        public override Coffee MakeCoffee()
        {
            if (FakeCache.TryGetValue("coffee") != null)
                return FakeCache.TryGetValue("coffee");

            var coffee = base.MakeCoffee();

            FakeCache.InsertValue(coffee);
            
            return coffee;

        }
    }
}
