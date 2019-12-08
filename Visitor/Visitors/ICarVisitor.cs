using Visitor.Visitors;

namespace Visitor
{
  public interface ICarVisitor<T> : ICarVisitor
  {
      T ProduceResult();
  }

  public interface ICarVisitor : ICarPartVisitor
  {
        public void Visit(Car car);  
  }
   
}