using Tyuiu.SadykovSV.Sprint2.Task4.V13.Lib;
namespace Tyuiu.SadykovSV.Sprint2.Task4.V13.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidOperation1()
        {
            DataService ds = new DataService();
            double x = 4.0;
            double y = 5.0;
            double res = ds.Calculate(x,y);
            Assert.AreEqual(53.75, res);
        }
        [TestMethod]
        public void ValidOperation2()
        {
            DataService ds = new DataService();
            double x = 4.0;
            double y = 15.0;
            double res = ds.Calculate(x, y);
            Assert.AreEqual(0.127, res);
        }
    }
}
