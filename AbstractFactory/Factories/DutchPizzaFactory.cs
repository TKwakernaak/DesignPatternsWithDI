using System;
using System.Collections.Generic;
using System.Text;
using AbstractFactory.Ingredients;
using AbstractFactory.Ingredients.Dough;

namespace AbstractFactory
{
    public class DutchPizzaIngredientFactory : IPizzaIngredientFactory
    {
        public Cheese CreateCheese()
        {
            return new GoudaCheese();
        }

        public Clams CreateClams()
        {
            return new FrozenClams();
        }

        public Dough CreateDough()
        {
            return new DutchDough();
        }

        public Pepperoni CreatePepperoni()
        {
            return new DutchPepperoni();
        }

        public Sauce CreateSauce()
        {
            return new DutchWhiteSauce();
        }

        public Veggies[] CreateVeggies()
        {
            throw new NotImplementedException();
        }
    }
}
