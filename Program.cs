using System;

namespace Siralama_Algoritmalari_CS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] dizi = { 5, 9, 1, 6, 518, 2, -6, 0, 12, 0};
            SiralamaAlgoritmalari<int>.MergeSort(dizi, SiralamaTuru.Descending);

            foreach (var item in dizi)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}