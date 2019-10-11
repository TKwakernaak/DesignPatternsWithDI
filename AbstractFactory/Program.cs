using System;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {

            Container.RegisterDependencies();
            var pizzadelegate = Container.Resolve<Pizzadelegate>();
            pizzadelegate.CreatePizza(PizzaStoreTypes.DutchPizzaStore, "Cheese");

            Console.ReadLine();
            
        }
    }
}
