using Tyuiu.ChigurovMV.Sprint2.Task4.V26.Lib;
namespace Tyuiu.ChigurovMV.Sprint2.Task4.V26.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x, y;
            x = 3.0;
            y = 6.0;
            double res = ds.Calculate(x, y);
            double wait = 1140963.910;
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void TestMethod2()
        {
            DataService ds = new DataService();
            double x, y;
            x = 6;
            y = 4;
            double wait = 35.75;
            double res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}