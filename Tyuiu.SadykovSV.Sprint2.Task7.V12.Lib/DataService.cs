using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.SadykovSV.Sprint2.Task7.V12.Lib
{
    public class DataService : ISprint2Task7V12
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            bool result;
            if (((y>= 2 - x) && (y<=Math.Pow(x,2)) && (x<=0)) || ((y <= Math.Pow(x, 2)) && (y <= 2 - x) && (x>=0) && (y>=0)))
            {
                result = true;
            }
            else
            {
                result = false;
            }
            return result;
        }
    }
}
