using Tyuiu.MazurkevichVS.Sprint6.Task1.V8.Lib;
namespace Tyuiu.MazurkevichVS.Sprint6.Task1.V8.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int start = -5;
            int end = 5;
            double[] wait = new double[] { -36.41, -22.07, 5.68, 16.72, 8.35, -0.50, 9.63, 16.29, 5.01, -22.40, -36.30 };
            double[] res = ds.GetMassFunction(start, end);
            CollectionAssert.AreEqual(wait, res);
        }
    }
}
