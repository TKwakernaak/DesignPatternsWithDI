using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern.Quacbehaviors
{
  public class QuackLoudly : IQuackBehavior
  {
    public void PerformQuack() => Console.Write("Quacking loudly");
  }
}
