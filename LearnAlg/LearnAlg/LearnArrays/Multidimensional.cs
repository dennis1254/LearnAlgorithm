using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnAlg.LearnArrays
{
    public class Multidimensional
    {
        public void PrintAll()
        {
            //2D Array
            int[,] array2D = new int [3,4] {
                                            { 3, 4, 5,6 }, 
                                            { 23, 43, 5,5 },
                                            { 3, 4, 9, 6 }
                                        };
            //3D Array
            int[,,] array3Da = new int[2, 2, 3] { 
                                                    { { 1, 2, 3 }, { 4, 5, 6 } },
                                                    { { 7, 8, 9 }, { 10, 11, 12 } } 
                                                };

            int[,,] array3Db = new int[2,3, 4] {
                                            { { 3, 4, 5,6 },{ 23, 43, 5,5 },{ 3, 4, 9, 6 } }, 
                                            { { 3, 4, 5,6 }, { 23, 43, 5,5 },{ 3, 4, 9, 6 } }
                                        };
        }

        public static void Print2DArray(int[,] arr)
        {
            // i - row index, j - column index
            for(int i = 0; i < arr.Length; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    Console.WriteLine();
                }
            }
        }
        

    }
}
