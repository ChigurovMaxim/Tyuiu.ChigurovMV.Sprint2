using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.ChigurovMV.Sprint2.Task7.V14.Lib
{
    public class DataService : ISprint2Task7V14
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            if ((Math.Pow(x,2) + Math.Pow(y,2) <= 1) && (x >= 0) || (Math.Pow(x, 2) + Math.Pow(y, 2) <= 1) && (y + x >= 0))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
