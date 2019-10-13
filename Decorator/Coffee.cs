namespace Decorator
{
    public class Coffee
    {
        private readonly string coffeeName;

        public Coffee(string coffeeName)
        {
            this.coffeeName = coffeeName;
        }

        public string getCoffeeName => coffeeName; 

    }
}