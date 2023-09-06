using System;

namespace Siralama_Algoritmalari_CS
{
    public static partial class SiralamaAlgoritmalari<T> where T : IComparable<T>
    {
        public static void SelectionSort(T[] dizi, SiralamaTuru tur = SiralamaTuru.Ascending)
        {
            for (int i = 0; i < dizi.Length - 1; i++)
                for (int j = i + 1; j < dizi.Length; j++)
                    if (Karsilastir(dizi[i], dizi[j], tur) > 0)
                    {
                        T depo = dizi[j];
                        dizi[j] = dizi[i];
                        dizi[i] = depo;
                    }
        }
    }
}
