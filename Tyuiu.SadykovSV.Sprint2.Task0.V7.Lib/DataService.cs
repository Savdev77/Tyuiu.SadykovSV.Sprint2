using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.SadykovSV.Sprint2.Task0.V7.Lib
{
    public class DataService : ISprint2Task0V7
    {
        public bool[] GetCompareOperations(int x, int y)
        {
            bool[] results = new bool[6];
            results[0] = x + 372 == y;
            results[1] = x + 372 != y; 
            results[2] = x < y;  
            results[3] = x + 373 > y;  
            results[4] = x <= y; 
            results[5] = x >= y; 
            return results;
        }
    }
}
