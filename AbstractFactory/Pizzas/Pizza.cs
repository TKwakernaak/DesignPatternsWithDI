using AbstractFactory.Ingredients;
using AbstractFactory.Ingredients.Dough;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public abstract class Pizza
    {
       protected string Name { get; set; }
       protected Dough Dough { get; set; }
       protected Sauce Sauce { get; set; }
       protected Veggies[] Veggies { get; set; }
       protected Cheese Cheese { get; set; }
       protected Pepperoni Pepperoni { get; set; }
       protected Clams Clam { get; set; }


        //here we will collect the ingredients needed for the pizza (retrieved from the factory, obviously).
        public abstract void Prepare();

        public void bake() { Console.WriteLine("Baking pizza"); }



    }
}
