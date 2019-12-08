using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor
{
  public class EngineStructure
  {
    public float Power { get; private set; }
    public float CylinderVolume { get; private set; }
    public EngineStructure(float Power, float cylinderVolume)
    {
      this.Power = Power;
      this.CylinderVolume = cylinderVolume;
    }
  }
}
