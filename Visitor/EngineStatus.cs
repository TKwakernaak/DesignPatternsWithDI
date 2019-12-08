using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor
{
  public class EngineStatus
  {
        public int Temperature { get; private set;}
        public int CylinderVolume {get; private set;}

    public EngineStatus(int temperature, int cylinderVolume)
    {
        Temperature    = temperature;
        CylinderVolume = cylinderVolume;
    }
  }
}
