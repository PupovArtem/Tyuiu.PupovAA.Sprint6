using Tyuiu.PupovAA.Sprint6.Task0.V29.Lib;
namespace Tyuiu.PupovAA.Sprint6.Task0.V29.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = ds.Calculate(3);
            Assert.AreEqual(0.722, x);
            
        }
    }
}
