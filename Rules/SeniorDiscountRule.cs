using Rules.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Rules
{
  public class SeniorDiscountRule : IDiscountRule<Customer>
  {
    public decimal Execute(Customer value)
    {
      if (value.DateOfBirth.AddYears(65) > DateTime.Now)
        return 0.11M;
      else
        return 0;
    }
  }
}
