using Autofac;
using StrategyPattern.Flybehaviors;
using StrategyPattern.Flybehaviors.Subinterfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
  public static class Container
  {

    private static IContainer _container { get; set; }
    public static T Resolve<T>() where T : class => _container.Resolve<T>();

    public static void RegisterDependencies()
    {
      var builder = new ContainerBuilder();

      ///each of the concrete types is registered usings its own interface to differentiate them, and inherit from our IFlybehavior.
      /// see https://autofaccn.readthedocs.io/en/latest/faq/select-by-context.html
      builder.RegisterType<FlyWithBricks>().As<IFlyWithBricks>();
      builder.RegisterType<FlyWithWings>().As<IFlyWithWings>();
      builder.RegisterType<DuckFarm>().As<IDuckFarm>();


      _container = builder.Build();
    }
  }
}
