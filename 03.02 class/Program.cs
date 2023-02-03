using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03._02_class
{
    internal class Program
    {
        static void SwapMinMax(int[][] a)
        {
            int max = a[0].Length;
            int min = a[0].Length;
            int imin = 0, imax = 0;
            for (int i = 1; i < a.Length; i++)
            {
                if (max < a[i].Length)
                {
                    imax = i;
                    max = a[i].Length;
                }
                if (min > a[i].Length)
                {
                    imin = i;
                    min = a[i].Length;
                }
            }
            (a[imax], a[imin]) = (a[imin], a[imax]);
        }
        static void RadomJageedArray(int[][] a)
        {
            Random r = new Random();
            Random r2 = new Random();
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = new int[r.Next(1, 20)];
                for (int j = 0; j < a[i].Length; j++)
                {
                    
                    a[i][j] = r2.Next(1,10);
                }
            }
        }
        static void PrintJagged(int[][] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < a[i].Length; j++)
                {
                    Console.Write("{0,4}", a[i][j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            #region //tast1
            int[][] MyArray = new int[5][];
            RadomJageedArray(MyArray);
            PrintJagged(MyArray);
            SwapMinMax(MyArray);
            PrintJagged(MyArray);
            Console.WriteLine();
            Console.WriteLine();
            #endregion

            #region //tast2
            int[][] MyArray2 = new int[4][];
            for (int i = 0; i < MyArray2.Length - 1; i++)
            {
                MyArray2[i] = new int[6 - i];
                for (int j = 0; j < MyArray2[i].Length; j++)
                { 
                        Console.Write(MyArray2[i][j] = 0); 
                }
                Console.WriteLine();
            }
            MyArray2[3] = new int[2];

            for (int i = 0; i < MyArray2[3].Length; i++)
            {
                Console.Write(MyArray2[3][i] = 0);
            }
            Console.WriteLine();
            #endregion
        }
    }
}
