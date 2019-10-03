using Microsoft.VisualStudio.TestPlatform.TestHost;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StrategyPattern;

namespace Executer
{
  [TestClass]
  public class UnitTest1
  {
    [TestMethod]
    public void Test_ExecuteStrategyPattern()
    {

      var sut = new DuckProgram();

      sut.Start();


    }
  }
}
