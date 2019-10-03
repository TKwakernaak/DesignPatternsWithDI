using StrategyPattern.Flybehaviors.Subinterfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern.Flybehaviors
{
  public class FlyWithBricks : IFlyWithBricks
  {
    public void PerformFly() => Console.WriteLine("flying with bricks attached to the wings");
  }
}