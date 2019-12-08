using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor.Visitors
{
  public class SaveCarVisitor : ICarVisitor
  {
    public void Visit(Car car)
    {
      Console.WriteLine("INSERT INTO Carshop.Car(car.make, car.model)\n" + "VALUES ('{0}', '{1}); \n");
    }
    public void VisitEngine(EngineStructure engine, EngineStatus status) => throw new NotImplementedException();
    public void VisitSeat(Seat seat)
    {
      Console.WriteLine("seat.Accept");
    }
  }
}
