using Tyuiu.KorotkovNS.Sprint5.Task3.V15.Lib;
namespace Tyuiu.KorotkovNS.Sprint5.Task3.V15
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int x = 5;
            DataService ds = new DataService();
            Console.Title = "Спринт #5 | Выполнил: Коротков Н. С. | ИСТНб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Класс file. Потоковый метод записи данных в бинарный файл         *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #15                                                              *");
            Console.WriteLine("* Выполнил: Коротков Никита Сергеевич | ИСТНб-24-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дано выражение, вычислить его значение при х = 5                        *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("x = " + x);


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            string res = ds.SaveToFileTextData(x);
            Console.WriteLine("Файл: " + res);
            Console.WriteLine("Создан!");
            Console.ReadKey();
        }
    }
}
