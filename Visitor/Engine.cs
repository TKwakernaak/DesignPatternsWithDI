using System;
using System.Collections.Generic;
using System.Text;
using Visitor.Visitors;

namespace Visitor
{
  public class Engine
  {
    public readonly float Power;
    public readonly float CylinderVolume;

    public Engine(float Power, float cylinderVolume)
    {
      this.CylinderVolume = cylinderVolume;
      this.Power = Power;
    }


    public void Accept(Func<ICarPartVisitor> visitorFactory)
    {
      EngineStructure structure = new EngineStructure(this.Power, this.CylinderVolume);
      EngineStatus status = new EngineStatus(10, 5);

      visitorFactory().VisitEngine(structure, status);
    }
  }
}
