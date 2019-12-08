using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor
{
  public class Program
  {

    //a simple tryout, DI gives no usefull benefits here.
    static void Main(string[] args)
    {
       new CarsView(new CarRepository().GetCars()).Render();

      Console.ReadKey();
    }
  }
}


