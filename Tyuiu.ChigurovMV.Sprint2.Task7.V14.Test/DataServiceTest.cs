using Tyuiu.ChigurovMV.Sprint2.Task7.V14.Lib;

namespace Tyuiu.ChigurovMV.Sprint2.Task7.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckDotInShadedAreaTest()
        {
            DataService ds = new DataService();
            double x, y;
            x = -0.5;
            y = 0.25;
            bool res = ds.CheckDotInShadedArea(x, y);
            bool wait = false;
            Assert.AreEqual(wait, res);
        }
    }
}