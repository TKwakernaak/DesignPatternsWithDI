using Autofac;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public static class Container
    {

        private static IContainer _container { get; set; }
        public static T Resolve<T>() where T : class => _container.Resolve<T>();

        public static void RegisterDependencies()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<NYPizzaStore>().Keyed<IPizzaStore>(PizzaStoreTypes.NyPizzaStore);
            builder.RegisterType<DutchPizzaStore>().Keyed<IPizzaStore>(PizzaStoreTypes.DutchPizzaStore);
            builder.RegisterType<Pizzadelegate>();

            _container = builder.Build();
        }
    }
}

