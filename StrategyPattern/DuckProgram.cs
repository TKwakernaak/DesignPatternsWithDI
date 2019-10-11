using System;

namespace StrategyPattern
{
    public class DuckProgram
    {
        /// <summary>
        /// the trick to using ID with stategies is (at least in this example) to Create subclasses of the interface (which can be just placeholders), to identify different strategies.
        /// </summary>

        public void Start()
        {
            Container.RegisterDependencies();
            var duckfarm = Container.Resolve<IDuckFarm>();
            duckfarm.Start();

        }



    }
}
