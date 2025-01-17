﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;
using System.IO;

namespace Tyuiu.VlasovDS.Sprint6.Task7.V14.Lib
{
    public class DataService : ISprint6Task7V14
    {
        public int[,] GetMatrix(string path)
        {
            string fileData = File.ReadAllText(path);

            fileData = fileData.Replace('\n', '\r');
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);


            int rows = lines.Length;
            int columns = lines[0].Split(';').Length;
            int[,] matrix = new int[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                string[] values = lines[i].Split(';');

                for (int j = 0; j < columns; j++)
                {
                    matrix[i, j] = int.Parse(values[j]);

                    if (matrix[1, j] % 2 == 0)
                    {
                        matrix[1, j] = 44;
                    }
                }
            }
            return matrix;
        }
    }
}
