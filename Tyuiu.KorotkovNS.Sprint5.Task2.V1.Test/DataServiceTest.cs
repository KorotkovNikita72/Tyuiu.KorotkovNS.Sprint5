using Tyuiu.KorotkovNS.Sprint5.Task2.V1.Lib;
using System.IO;
namespace Tyuiu.KorotkovNS.Sprint5.Task2.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\Nikita\AppData\Local\Temp\OutPutFileTask2.csv";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}