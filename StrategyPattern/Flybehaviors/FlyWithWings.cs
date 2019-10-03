using StrategyPattern.Flybehaviors.Subinterfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern.Flybehaviors
{
  public class FlyWithWings : IFlyWithWings
  {
    public void PerformFly() {Console.WriteLine("fly with wings");}
  }
}
