using Tyuiu.ChigurovMV.Sprint2.Task1.V23.Lib;

namespace Tyuiu.ChigurovMV.Sprint2.Task1.V23.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetLogicOperations()
        {
            DataService ds = new DataService();
            bool[] res = new bool[6];
            int a = 242;
            int b = 571;
            int c = 325;
            int d = 155;
            res = ds.GetLogicOperations(a, b, c, d);
            bool[] wait = new bool[6] { false, false, false, true, true, true };
            CollectionAssert.AreEqual(wait, res);
        }
    }
}