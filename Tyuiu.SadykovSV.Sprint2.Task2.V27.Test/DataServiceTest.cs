using Tyuiu.SadykovSV.Sprint2.Task2.V27.Lib;

namespace Tyuiu.SadykovSV.Sprint2.Task2.V27.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckDotInShadedArea()
        {
            DataService ds = new DataService();
            int x = 6;
            int y = 11;
            bool expected = true;
            bool res = ds.CheckDotInShadedArea(x, y);
            Assert.AreEqual(expected, res);
        }
    }
}
