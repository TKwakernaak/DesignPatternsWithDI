using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public class PepperoniPizza : Pizza
    {

        private readonly IPizzaIngredientFactory _ingredientFactory;

        public PepperoniPizza(IPizzaIngredientFactory ingredientFactory)
        {
            _ingredientFactory = ingredientFactory;
        }
        public override void Prepare()
        {
            Console.WriteLine("preparing pizza" + Name);

            Dough = _ingredientFactory.CreateDough();
            Sauce = _ingredientFactory.CreateSauce();
            Cheese = _ingredientFactory.CreateCheese();


        }
    }
}
