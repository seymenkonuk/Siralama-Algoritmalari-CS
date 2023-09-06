using System;

namespace Siralama_Algoritmalari_CS
{
    public static partial class SiralamaAlgoritmalari<T> where T : IComparable<T>
    {
        public static void InsertionSort(T[] dizi, SiralamaTuru tur = SiralamaTuru.Ascending)
        {
            for (int i = 1; i < dizi.Length; i++)
            {
                for (int j = i - 1; j >= 0; j--)
                    if (Karsilastir(dizi[j], dizi[j + 1], tur) > 0)
                    {
                        T depo = dizi[j];
                        dizi[j] = dizi[j + 1];
                        dizi[j + 1] = depo;
                    }
                    else
                    {
                        break;
                    }
            }
        }
    }
}
