using System;

namespace Siralama_Algoritmalari_CS
{
    public static partial class SiralamaAlgoritmalari<T> where T : IComparable<T>
    {
        public static void BubbleSort(T[] dizi, SiralamaTuru tur = SiralamaTuru.Ascending)
        {
            bool bittiMi;
            do
            {
                bittiMi = true;
                for (int j = 1; j < dizi.Length; j++)
                    if (Karsilastir(dizi[j - 1], dizi[j], tur) > 0)
                    {
                        T depo = dizi[j];
                        dizi[j] = dizi[j - 1];
                        dizi[j - 1] = depo;
                        bittiMi = false;
                    }
            } while (!bittiMi);
        }
    }
}
