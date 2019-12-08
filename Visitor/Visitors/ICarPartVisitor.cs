using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor.Visitors
{
  public interface ICarPartVisitor
  {
    public void VisitEngine(EngineStructure engine, EngineStatus status);

    public void VisitSeat(Seat seat);
  }
}
