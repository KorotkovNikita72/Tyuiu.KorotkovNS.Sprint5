﻿using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.KorotkovNS.Sprint5.Task0.V15.Lib
{
    public class DataService : ISprint5Task0V15
    {
        public string SaveToFileTextData(int x)
        {
            string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask0.txt";
            double y = x / (Math.Pow(x, 3) + 2);
            y = Math.Round(y, 3);
            File.WriteAllText(path, Convert.ToString(y));
            return path;
        }
    }
}