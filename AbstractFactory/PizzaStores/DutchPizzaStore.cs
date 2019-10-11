using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public class DutchPizzaStore : IPizzaStore
    {
        private IPizzaIngredientFactory pizzaIngredientFactory;

        public Pizza CreatePizza(string name)
        {
            pizzaIngredientFactory = new DutchPizzaIngredientFactory();

            if (name.Equals("Cheese"))
                return new CheesePizza(pizzaIngredientFactory);
            else
                return new PepperoniPizza(pizzaIngredientFactory);
        }
    }
}
