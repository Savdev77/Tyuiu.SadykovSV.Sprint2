using Tyuiu.SadykovSV.Sprint2.Task3.V27.Lib;
namespace Tyuiu.SadykovSV.Sprint2.Task3.V27.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1()
        {
            DataService ds = new DataService();
            double x = 1;
            double res = ds.Calculate(x);
            Assert.AreEqual(1.491, res);
        }
        [TestMethod]
        public void ValidCondition2()
        {
            DataService ds = new DataService();
            double x = 0;
            double res = ds.Calculate(x);
            Assert.AreEqual(0.25, res);
        }
        [TestMethod]
        public void ValidCondition3()
        {
            DataService ds = new DataService();
            double x = -10;
            double res = ds.Calculate(x);
            Assert.AreEqual(1.02, res);
        }
        [TestMethod]
        public void ValidCondition4()
        {
            DataService ds = new DataService();
            double x = -32;
            double res = ds.Calculate(x);
            Assert.AreEqual(-32798.961, res);
        }
    }
}
