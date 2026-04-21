using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demopract
{


    internal class Program
    {
      
        static void Main(string[] args)
        {


            int[,] arr = new int[2, 3]
            {
                {10,20,30 },
                {40,50,60 }

            };

            for(int i=0;i<2;i++)
            {
                for(int j=0;j<3;j++)
                {
                    Console.Write(arr[i, j]+" ");
                }
                Console.WriteLine();
            }

        //    int[,] arr = new int[2, 3]
        //{
        //    {10, 20, 30},
        //    {40, 50, 60}
        //};

        //    for (int i = 0; i < 2; i++) // rows
        //    {
        //        for (int j = 0; j < 3; j++) // columns
        //        {
        //            Console.Write(arr[i, j] + " ");
        //        }
        //        Console.WriteLine();
        //    }
        }
    }
}
