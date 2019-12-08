using System;
using System.Collections.Generic;
using System.Text;
using Visitor.Visitors;

namespace Visitor
{
  public class Seat
  {
    private readonly string Name;
    public readonly int Capacity;

    public Seat(string name, int capacity)
    {
      this.Name = name;
      this.Capacity = capacity;
    }


    public void Accept(Func<ICarPartVisitor> visitorfactory)
    {
      visitorfactory().VisitSeat(this);
    }
  }
}
