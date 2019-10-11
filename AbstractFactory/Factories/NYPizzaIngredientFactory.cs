using System;
using System.Collections.Generic;
using System.Text;
using AbstractFactory.Ingredients;
using AbstractFactory.Ingredients.Dough;

namespace AbstractFactory
{
    public class NYPizzaIngredientFactory : IPizzaIngredientFactory
    {
        public Cheese CreateCheese()
        {
            return new NYCheese();
        }

        public Clams CreateClams()
        {
            return new FreshClams();
        }

        public Dough CreateDough()
        {
            return new RegularDough();
        }

        public Pepperoni CreatePepperoni()
        {
            return new SpicyPepperoni();
        }

        public Sauce CreateSauce()
        {
            return new TomatoSuperSauce();
        }

        public Veggies[] CreateVeggies()
        {
            return new Veggies[] { new Garlic(), new Onion() };
        }
    }
}
