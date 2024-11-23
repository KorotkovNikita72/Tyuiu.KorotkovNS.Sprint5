using System.IO;
using Tyuiu.KorotkovNS.Sprint5.Task0.V15.Lib;
namespace Tyuiu.KorotkovNS.Sprint5.Task0.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\Nikita\source\repos\Tyuiu.KorotkovNS.Sprint5.Task0.V15\Tyuiu.KorotkovNS.Sprint5.Task0.V15\bin\Debug\net8.0\OutPutFileTask0.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}