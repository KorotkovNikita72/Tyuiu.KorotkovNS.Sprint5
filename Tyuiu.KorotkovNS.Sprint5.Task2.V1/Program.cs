using Tyuiu.KorotkovNS.Sprint5.Task2.V1.Lib;
namespace Tyuiu.KorotkovNS.Sprint5.Task2.V1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] mtrx = new int[3, 3] { {6,9,4 },
                                          {7,2,4 },
                                          {4,8,3 }};
            int rows = mtrx.GetUpperBound(0) + 1;
            int colms = mtrx.Length / rows;
            DataService ds = new DataService();
            Console.Title = "Спринт #5 | Выполнил: Коротков Н. С. | ИСТНб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Класс file. Запись структурированных данных в текстовый файл      *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #1                                                              *");
            Console.WriteLine("* Выполнил: Коротков Никита Сергеевич | ИСТНб-24-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан двумерный массив. Заменить нечетные элементы массива на 0           *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Массив:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0;j<colms; j++)
                {
                    Console.Write($"{mtrx[i,j]} \t");
                }
                Console.WriteLine();
            }


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            string res = ds.SaveToFileTextData(mtrx);
            Console.WriteLine("Файл: " + res);
            Console.WriteLine("Создан!");
            Console.ReadKey();
        }
    }
}
