using Rules.Models;
using System;

namespace Rules
{
  class Program
  {
    static void Main(string[] args)
    {
      var customer = new Customer();
      customer.DateOfBirth = DateTime.Today.AddYears(-67);
      customer.FirstName = "Nathan";
      customer.LastName = "Burger";

      var calculator = new DiscountCalculator();
      var result = calculator.CalculateDiscountPercentage(customer);

    }
  }
}
