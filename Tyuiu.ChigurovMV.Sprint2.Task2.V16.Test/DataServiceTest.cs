using Tyuiu.ChigurovMV.Sprint2.Task2.V16.Lib;

namespace Tyuiu.ChigurovMV.Sprint2.Task2.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckDotInSharedArea()
        {
            DataService ds = new DataService();
            int x = 4;
            int y = 4;

            bool res = ds.CheckDotInShadedArea(x, y);
            bool wait = true;

            Assert.AreEqual(wait, res);
        }
    }
}