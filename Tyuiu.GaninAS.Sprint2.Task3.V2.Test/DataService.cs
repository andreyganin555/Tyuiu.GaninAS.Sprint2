using Tyuiu.GaninAS.Sprint2.Task3.V2.Lib;

namespace Tyuiu.GaninAS.Sprint2.Task3.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1()
        {
            DataService ds = new DataService();
            double x = 4;
            double res = ds.Calculate(x);
            double wait = -44.654;
            Assert.AreEqual(wait, res);
        }
    }
}