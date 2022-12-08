/*               /// 2D array Input by user////
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{

    class Program
    {        
        static void Main(string[]args)
        {
            int i, j;
            Console.Write("Enter your row size:");
            i = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter your column size:");
            j = Convert.ToInt32(Console.ReadLine());
            int[,] array = new int[i, j];
            Console.WriteLine("Enter your Array element:");
            for (int x = 0; x < i; x++) {
                for (int y = 0; y < j; y++) {
                    array[x, y] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("Your array:");
            for (int x = 0; x < i; x++) {
                for (int y = 0; y < j; y++) {
                    Console.Write(array[x, y] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}*/
