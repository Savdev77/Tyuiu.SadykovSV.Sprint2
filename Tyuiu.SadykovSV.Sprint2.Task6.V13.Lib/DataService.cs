using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.SadykovSV.Sprint2.Task6.V13.Lib
{
    public class DataService : ISprint2Task6V13
    {
        public string FindDateOfNextDay(int g, int m, int n)
        {
            int DaysInMonth = 0;
            switch (m)
            {
                case 1: case 3:case 5:case 7:case 8:case 10:case 12:
                    DaysInMonth = 31;
                    break;
                case 4:case 6:case 9:case 11:
                    DaysInMonth = 30;
                    break;
                case 2:
                    DaysInMonth = 29;
                    break;
            }
            if (n < DaysInMonth)
            {
                n++;
            }
            else
            {
                n = 1;
                if (m == 12)
                {
                    m = 1;
                    g++;
                }
                else
                {
                    m++;
                }
            }
            return $"{n} число {m} месяц {g} год";
        }
    }
}
