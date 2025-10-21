using Tyuiu.GaninAS.Sprint2.Task4.V30.Lib;

namespace Tyuiu.GaninAS.Sprint2.Task4.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestCalculate()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 3;
            double wait = 343;
            double res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}