using Tyuiu.SadykovSV.Sprint2.Task5.V12.Lib;
namespace Tyuiu.SadykovSV.Sprint2.Task5.V12.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidFindDateOfPreviousDay()
        {
            DataService ds = new DataService();
            int g = 2024;
            int m = 3;
            int n = 1;
            string result = ds.FindDateOfPreviousDay(g, m, n);
            string expected = "29 число 2 месяц 2024 год";
            Assert.AreEqual(expected, result);
        }
    }
}
