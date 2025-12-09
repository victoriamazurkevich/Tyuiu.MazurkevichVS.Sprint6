using Tyuiu.MazurkevichVS.Sprint6.Task0.V22.Lib;
namespace Tyuiu.MazurkevichVS.Sprint6.Task0.V22.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int x = 2;
            double res = ds.Calculate(x);
            double wait = 11.68;
            Assert.AreEqual(res, wait);
        }
    }
}
