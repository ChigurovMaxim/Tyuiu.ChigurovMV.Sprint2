using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.ChigurovMV.Sprint2.Task1.V23.Lib
{
    public class DataService : ISprint2Task1V23
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] res = new bool[6];

            res[0] = (a > b) | (c < d);
            res[1] = (a < c) & (b == c);
            res[2] = (a > b) || (c < d);
            res[3] = (a < c) && (b > c);
            res[4] = !res[0];
            res[5] = (b != c) ^ (c < d);
            return res;

        }
    }
}
