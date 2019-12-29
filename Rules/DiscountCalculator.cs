using Rules.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rules
{
  public class DiscountCalculator
  {
    private List<IDiscountRule<Customer>> discountRules = new List<IDiscountRule<Customer>>();
    public DiscountCalculator()
    {
      discountRules.Add(new SeniorDiscountRule());
      discountRules.Add(new BirthDayDiscountRule());
    }

    public decimal CalculateDiscountPercentage(Customer customer)
    {
      return discountRules.Max(e => e.Execute(customer));
    }
  }
}
