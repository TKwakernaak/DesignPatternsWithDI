using Rules.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Rules
{
  public class BirthDayDiscountRule : IDiscountRule<Customer>
  {
    public decimal Execute(Customer value)
    {
      if (value.DateOfBirth.Day == DateTime.Today.Day)
        return 0.10m;
      else
        return 0;
    }
  }
}
