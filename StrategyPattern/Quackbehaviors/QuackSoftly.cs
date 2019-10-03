using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern.Quacbehaviors
{
  public class QuackSoftly : IQuackBehavior
  {
    public void PerformQuack() => Console.WriteLine("Quacking softly");
  }
}
