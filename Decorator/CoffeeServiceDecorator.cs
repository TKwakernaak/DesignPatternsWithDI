using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    public abstract class CoffeeServiceDecorator : ICoffeeService
    {
        protected readonly ICoffeeService coffeeService;

        public CoffeeServiceDecorator(ICoffeeService coffeeService)
        {
            this.coffeeService = coffeeService;
        }

        public virtual Coffee MakeCoffee()
        {
            return coffeeService.MakeCoffee();
        }
    }
}
