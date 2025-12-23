using System.IO;
using Tyuiu.PupovAA.Sprint6.Task7.V20.Lib;

namespace Tyuiu.PupovAA.Sprint6.Task7.V20.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Пользователи\artem\source\repos\Tyuiu.PupovAA.Sprint6\Tyuiu.PupovAA.Sprint6.Task7.V20.Lib\Текстовый документ";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
