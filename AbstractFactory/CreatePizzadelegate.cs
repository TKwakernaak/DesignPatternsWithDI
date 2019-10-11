using Autofac.Features.Indexed;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public class Pizzadelegate
    {
        private readonly IIndex<PizzaStoreTypes, IPizzaStore> pizzaStores;

        private IPizzaStore _selectedPizzastore;

        public Pizzadelegate(IIndex<PizzaStoreTypes, IPizzaStore> pizzaStores)
        {
            this.pizzaStores = pizzaStores;
        }


        public void CreatePizza(PizzaStoreTypes storeType, string name)
        {
            _selectedPizzastore = pizzaStores[storeType];

            _selectedPizzastore.CreatePizza(name);
        }
    }
}
