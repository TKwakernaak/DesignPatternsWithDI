using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
  public class Duck
  {

    IFlyBehaviour _flyBehaviour;
    IQuackBehavior _quackBehavior;

    public Duck()
    {

    }

    public void SetFlyBehavior(IFlyBehaviour flyBehaviour)
    {
      _flyBehaviour = flyBehaviour;
    }

    public void SetQuackBehavior(IQuackBehavior quackBehavior)
    {
      _quackBehavior = quackBehavior;
    }

    public void PerformFly()
    {
      _flyBehaviour.PerformFly();
    }
  }
}
