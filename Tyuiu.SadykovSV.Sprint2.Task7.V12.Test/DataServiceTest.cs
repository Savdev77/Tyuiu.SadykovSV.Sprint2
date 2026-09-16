using Tyuiu.SadykovSV.Sprint2.Task7.V12.Lib;

namespace Tyuiu.SadykovSV.Sprint2.Task7.V12.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckDotInShadedArea()
        {
            DataService ds = new DataService();
            double x = 1.0;
            double y = 0.0;
            bool result = ds.CheckDotInShadedArea(x,y);
            bool expected = true;
            Assert.AreEqual(expected, result);
        }
    }
}
