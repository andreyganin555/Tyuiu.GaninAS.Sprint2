using Tyuiu.GaninAS.Sprint2.Task6.V6.Lib;

namespace Tyuiu.GaninAS.Sprint2.Task6.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestFindCardNameAndValue()
        {
            DataService ds = new DataService();
         
            Assert.AreEqual("пик, шестерка", ds.FindCardNameAndValue(1, 6));
            Assert.AreEqual("пик, восьмерка", ds.FindCardNameAndValue(1, 8));
            Assert.AreEqual("пик, девятка", ds.FindCardNameAndValue(1, 9));
            Assert.AreEqual("пик, десятка", ds.FindCardNameAndValue(1, 10));
            Assert.AreEqual("пик, валет", ds.FindCardNameAndValue(1, 11));
            Assert.AreEqual("пик, дама", ds.FindCardNameAndValue(1, 12));
            Assert.AreEqual("пик, король", ds.FindCardNameAndValue(1, 13));
            Assert.AreEqual("пик, туз", ds.FindCardNameAndValue(1, 14));
            Assert.AreEqual("треф, шестерка", ds.FindCardNameAndValue(2, 6));
            Assert.AreEqual("треф, семерка", ds.FindCardNameAndValue(2, 7));
            Assert.AreEqual("треф, восьмерка", ds.FindCardNameAndValue(2, 8));
            Assert.AreEqual("треф, девятка", ds.FindCardNameAndValue(2, 9));
            Assert.AreEqual("треф, десятка", ds.FindCardNameAndValue(2, 10));
            Assert.AreEqual("треф, валет", ds.FindCardNameAndValue(2, 11));
            Assert.AreEqual("треф, дама", ds.FindCardNameAndValue(2, 12));
            Assert.AreEqual("треф, король", ds.FindCardNameAndValue(2, 13));
            Assert.AreEqual("треф, туз", ds.FindCardNameAndValue(2, 14));
            Assert.AreEqual("бубн, шестерка", ds.FindCardNameAndValue(3, 6));
            Assert.AreEqual("бубн, семерка", ds.FindCardNameAndValue(3, 7));
            Assert.AreEqual("бубн, восьмерка", ds.FindCardNameAndValue(3, 8));
            Assert.AreEqual("бубн, девятка", ds.FindCardNameAndValue(3, 9));
            Assert.AreEqual("бубн, десятка", ds.FindCardNameAndValue(3, 10));
            Assert.AreEqual("бубн, валет", ds.FindCardNameAndValue(3, 11));
            Assert.AreEqual("бубн, дама", ds.FindCardNameAndValue(3, 12));
            Assert.AreEqual("бубн, король", ds.FindCardNameAndValue(3, 13));
            Assert.AreEqual("бубн, туз", ds.FindCardNameAndValue(3, 14));
            Assert.AreEqual("черв, шестерка", ds.FindCardNameAndValue(4, 6));
            Assert.AreEqual("черв, семерка", ds.FindCardNameAndValue(4, 7));
            Assert.AreEqual("черв, восьмерка", ds.FindCardNameAndValue(4, 8));
            Assert.AreEqual("черв, девятка", ds.FindCardNameAndValue(4, 9));
            Assert.AreEqual("черв, десятка", ds.FindCardNameAndValue(4, 10));
            Assert.AreEqual("черв, валет", ds.FindCardNameAndValue(4, 11));
            Assert.AreEqual("черв, дама", ds.FindCardNameAndValue(4, 12));
            Assert.AreEqual("черв, король", ds.FindCardNameAndValue(4, 13));
            Assert.AreEqual("черв, туз", ds.FindCardNameAndValue(4, 14));
            Assert.ThrowsException<ArgumentException>(() =>
            {
                ds.FindCardNameAndValue(-1, 5);
            });
            Assert.ThrowsException<ArgumentException>(() =>
            {
                ds.FindCardNameAndValue(5, 15);
            });
        }
    }
}



        
    








