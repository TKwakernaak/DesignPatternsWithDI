using System;

namespace Decorator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Container.RegisterDependencies();

            //container resolves the ICoffeeservice & wraps it with an "CachedCoffeeService"
            var decoratedCoffeeservice = Container.Resolve<ICoffeeService>();

            //we call the cachedCoffeeservice to make our cofee, which returns some old coffee
            var coffee = decoratedCoffeeservice.MakeCoffee();

            if (coffee.getCoffeeName == "Old cached coffee")
                Console.WriteLine("retrieved cached coffee");
            else
                Console.Write("retrieved normal coffee");







        }
    }
}
