using Tyuiu.SadykovSV.Sprint2.Task6.V13.Lib;

namespace Tyuiu.SadykovSV.Sprint2.Task6.V13.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidFindDateOfNextDay()
        {
            DataService ds = new DataService();
            int g = 2024;
            int m = 2;
            int n = 28;
            string result = ds.FindDateOfNextDay(g, m, n);
            string expected = "29 число 2 месяц 2024 год";
            Assert.AreEqual(expected, result);
        }
    }
}   