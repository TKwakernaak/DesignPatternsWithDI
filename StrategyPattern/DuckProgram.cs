using System;

namespace StrategyPattern
{
  public class DuckProgram
  {


    public void Start()
    {
      Container.RegisterDependencies();
      var duckfarm = Container.Resolve<IDuckFarm>();
      duckfarm.Start();
    
    }



  }
}
