using System;
using Visitor.Visitors;

namespace Visitor
{
  public interface ICar
  {
    void Accept(Func<ICarVisitor> visitor);

    T Accept<T> (Func<ICarVisitor<T>> visitorFactory);
  }
}