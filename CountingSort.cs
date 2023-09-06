using System;

namespace Siralama_Algoritmalari_CS
{
    public static partial class SiralamaAlgoritmalari<T> where T : IComparable<T>
    {
        public static void CountingSort(byte[] dizi, SiralamaTuru tur = SiralamaTuru.Ascending)
        {
            int[] adetler = new int[256];

            for (int i = 0; i < dizi.Length; i++)
                adetler[dizi[i]]++;

            for (int i = 1; i < 256; i++)
                adetler[i] += adetler[i - 1];

            byte[] yedek = new byte[dizi.Length];
            for (int i = 0; i < dizi.Length; i++)
                yedek[--adetler[dizi[i]]] = dizi[i];

            for (int i = 0; i < dizi.Length; i++)
                dizi[i] = yedek[i];
        }
    }
}
