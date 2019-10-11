namespace AbstractFactory
{
    public interface IPizzaStore
    {
       Pizza CreatePizza(string name);
    }
}