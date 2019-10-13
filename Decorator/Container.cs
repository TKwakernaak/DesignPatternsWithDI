using Autofac;
using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    public static class Container
    {
        private static IContainer _container { get; set; }
        public static T Resolve<T>() where T : class => _container.Resolve<T>();

        public static void RegisterDependencies()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<CoffeeService>().As<ICoffeeService>();
            builder.RegisterDecorator<CoffeeServiceCacheDecorator, ICoffeeService>();
       
            _container = builder.Build();
        }
    }
}
