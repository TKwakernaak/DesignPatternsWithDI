using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    public class CoffeeService : ICoffeeService
    {
        public Coffee MakeCoffee()
        {
            return new Coffee("someCoffee");
        }
    }
}
