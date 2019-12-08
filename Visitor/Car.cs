using System;
using System.Collections.Generic;
using Visitor.Visitors;

namespace Visitor
{
  public class Car : ICar
  {
    public readonly string Make;

    public readonly string Model;
    private readonly Engine Engine;
    private readonly IEnumerable<Seat> Seats;

    public Car(string make, string model, Engine engine, IEnumerable<Seat> seats)
    {
      Make = make;
      Model = model;
      Engine = engine;
      Seats = seats;
    }

    public void Accept(Func<ICarVisitor> visitorFactory)
    {
      var visitor = visitorFactory();

      this.Engine.Accept(() => visitor);

      foreach (Seat seat in this.Seats)
      {
        seat.Accept(() => visitor);
      }
    }

    public T Accept<T>(Func<ICarVisitor<T>> visitorFactory)
    {
      ICarVisitor<T> visitor = visitorFactory();
      this.Accept(() => (ICarVisitor)visitor);
      return visitor.ProduceResult();
    }
  }
}
