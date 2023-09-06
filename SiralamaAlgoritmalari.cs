using System;

namespace Siralama_Algoritmalari_CS
{
    public enum SiralamaTuru
    {
        Descending,
        Ascending
    }
    public static partial class SiralamaAlgoritmalari<T> where T : IComparable<T>
    {
        private static int Karsilastir(T item1, T item2, SiralamaTuru tur = SiralamaTuru.Ascending)
        {
            if (tur == SiralamaTuru.Ascending)
                return item1.CompareTo(item2);
            return item2.CompareTo(item1);
        }
        
    }
}
