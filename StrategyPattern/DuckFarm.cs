using StrategyPattern.Flybehaviors.Subinterfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
  public class DuckFarm : IDuckFarm
  {
    private readonly IFlyWithBricks flyWithBricks;
    private readonly IFlyWithWings flyWithWings;

    public DuckFarm(IFlyWithBricks flyWithBricks, IFlyWithWings flyWithWings)
    {
      this.flyWithBricks = flyWithBricks;
      this.flyWithWings = flyWithWings;
    }

    public void Start()
    {
      var duck = new Duck();

      duck.SetFlyBehavior(flyWithWings);
      duck.PerformFly();
    }
  }
}
