using AbstractFactory.Ingredients;
using AbstractFactory.Ingredients.Dough;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public interface IPizzaIngredientFactory
    {
        public Dough CreateDough();

        public Sauce CreateSauce();

        public Cheese CreateCheese();

        public Veggies[] CreateVeggies();

        public Pepperoni CreatePepperoni();

        public Clams CreateClams();

    }
}
