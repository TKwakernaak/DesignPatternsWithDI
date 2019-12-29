using System;
using System.Collections.Generic;
using System.Text;

namespace Rules
{
  public interface IDiscountRule<T>
  {
    decimal Execute(T value);
  }
}
