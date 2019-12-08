using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor.Visitors
{
  public class CarToStringVisitor : ICarVisitor<string>
  {
    private string report;
    private int seatsCount;

    public void VisitSeat(Seat seat)
    {
      this.seatsCount += seat.Capacity;
    }

    public void Visit(Car car)
    {
      report += car.Make + " " + car.Model;
    }

    public void VisitEngine(EngineStructure engine, EngineStatus status)
    {
      report += engine.CylinderVolume + status.CylinderVolume;
    }

    public string ProduceResult()
    {
      return $"{this.report + this.seatsCount}";
    }
  }
}
