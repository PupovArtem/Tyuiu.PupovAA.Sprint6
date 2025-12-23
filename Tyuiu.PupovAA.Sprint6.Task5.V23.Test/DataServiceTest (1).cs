using Tyuiu.PupovAA.Sprint6.Task5.V23.Lib;

namespace Tyuiu.PupovAA.Sprint6.Task5.V23.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\katag\source\repos\Tyuiu.PupovAA.Sprint6\Tyuiu.PupovAA.Sprint6.Task5.V23";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
