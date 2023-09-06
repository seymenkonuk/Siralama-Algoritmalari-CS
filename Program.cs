using System;
using System.Collections.Generic;

namespace Siralama_Algoritmalari_CS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] dizi = { 5, 9, 1, 6, 518, 2, -6, 0, 12, 0};
            List<int> deneme = new List<int>(dizi);

            deneme = deneme.BubbleSort();

            foreach (var item in deneme)
                Console.Write(item + " ");
            
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}