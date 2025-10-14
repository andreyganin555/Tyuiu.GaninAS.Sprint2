using Tyuiu.GaninAS.Sprint2.Task2.V21.Lib;

namespace Tyuiu.GaninAS.Sprint2.Task2.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckDotInShadedArea()
        {
            DataService ds = new DataService();
            int x = 4;
            int y = 4;
            bool res = ds.CheckDotInShadedArea(x, y);
            bool wait = true;

            Assert.AreEqual(wait, true);
        }
    }
}