using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor
{
  public class CarRepository
  {

    public IEnumerable<Car> GetCars()
    {
      var list   = new List<Car>();
      var seat   = new List<Seat>{ new Seat("backSeat", 3) };
      var engine = new Engine(11, 100);
      var car1   = new Car("Seat", "Leon", engine, seat);

      return new List<Car> { car1};
    }
  }
}
