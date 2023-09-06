using System;
using System.Collections.Generic;

namespace Siralama_Algoritmalari_CS
{
    public static class ListSortExtension
    {
        public static List<T> BubbleSort<T>(this List<T> list, SiralamaTuru tur = SiralamaTuru.Ascending) where T : IComparable<T>
        {
            T[] arr = list.ToArray();
            SiralamaAlgoritmalari<T>.BubbleSort(arr, tur);
            return new List<T>(arr);
        }
        public static List<T> InsertionSort<T>(this List<T> list, SiralamaTuru tur = SiralamaTuru.Ascending) where T : IComparable<T>
        {
            T[] arr = list.ToArray();
            SiralamaAlgoritmalari<T>.InsertionSort(arr, tur);
            return new List<T>(arr);
        }
    }
}
