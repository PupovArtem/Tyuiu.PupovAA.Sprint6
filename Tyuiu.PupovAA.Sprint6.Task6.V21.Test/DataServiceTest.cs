
using System.IO;
using Tyuiu.PupovAA.Sprint6.Task6.V21.Lib;

namespace Tyuiu.PupovAA.Sprint6.Task6.V21.Test
{
    [TestClass]
    public class Test1
    {
        [TestMethod]
        public void CheckCollectTextFromFile()
        {
            
            string dir = Path.GetTempPath();
            string path = Path.Combine(dir, "Текстовый документ");
            File.WriteAllText(path, "good day great test");

            DataService ds = new DataService();

            
            string actual = ds.CollectTextFromFile(path);

            
            string expected = "good great";

            
            Assert.AreEqual(expected, actual);
        }
    }
}
