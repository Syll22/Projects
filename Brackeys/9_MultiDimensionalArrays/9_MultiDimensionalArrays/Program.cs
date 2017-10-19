using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_MultiDimensionalArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // Multi dimensional array

            CreateGrid();

            Console.ReadKey();
        }

        public static void CreateGrid ()
        {
            int width = 5;
            int height = 5;

            int[,] grid = new int[width, height];
            //grid[2, 3] = 4;

            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    grid[x, y] = x + y;
                    Console.Write(grid[x,y] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
