using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
using System.Text;
using System.Threading.Tasks;
namespace Tyuiu.KorotkovNS.Sprint5.Task3.V15.Lib
{
    public class DataService : ISprint5Task3V15
    {
        public string SaveToFileTextData(int x)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask3.bin");

            double y = -1.4 * Math.Pow(x, 3) + 2.3 * Math.Pow(x, 2) + 0.6 * x;

            y = Math.Round(y, 3);

            using (BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.OpenOrCreate), Encoding.UTF8))
            {
                writer.Write(BitConverter.GetBytes(y));
            }
            return path;
        }
    }
}
