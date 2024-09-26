using Tyuiu.ChigurovMV.Sprint2.Task3.V26.Lib;

namespace Tyuiu.ChigurovMV.Sprint2.Task3.V26.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CalcTest1()
        {
            DataService ds = new DataService();
            double x = 1;
            double res = ds.Calculate(x);
            double wait = 4.702;
            Assert.AreEqual(wait, res);
        }
        
        [TestMethod]
        public void CalcTest2()
        {
            DataService ds = new DataService();
            double x = 0;
            double res = ds.Calculate(x);
            double wait = 1.667;
            Assert.AreEqual(wait, res);
        }
        [TestMethod]
        public void CalcTest3()
        {
            DataService ds = new DataService();
            double x = -1;
            double res = ds.Calculate(x);
            double wait = -4.754;
            Assert.AreEqual(wait, res);
        }
        [TestMethod]
        public void CalcTest4()
        {
            DataService ds = new DataService();
            double x = -32;
            double res = ds.Calculate(x);
            double wait = -255.969;
            Assert.AreEqual(wait, res);
        }
    }
}