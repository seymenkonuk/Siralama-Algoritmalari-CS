using System;

namespace Siralama_Algoritmalari_CS
{
    public static partial class SiralamaAlgoritmalari<T> where T : IComparable<T>
    {
        public static void MergeSort(T[] dizi, SiralamaTuru tur = SiralamaTuru.Ascending)
        {
            MergeSort(dizi, 0, dizi.Length - 1, tur);
        }
        private static void MergeSort(T[] dizi, int baslangic, int bitis, SiralamaTuru tur)
        {
            if (baslangic < bitis)
            {
                int orta = (baslangic + bitis) / 2;
                MergeSort(dizi, baslangic, orta, tur);
                MergeSort(dizi, orta + 1, bitis, tur);
                Merge(dizi, baslangic, orta, bitis, tur);
            }
        }
        private static void Merge(T[] dizi, int baslangic, int orta, int bitis, SiralamaTuru tur)
        {
            // İki Dizinin Uzunlukları
            int n1 = orta - baslangic + 1;
            int n2 = bitis - orta;

            T[] left = new T[n1];
            T[] right = new T[n2];

            // Diziyi Kopyala
            for (int i = 0; i < n1; i++)
                left[i] = dizi[baslangic + i];
            for (int i = 0; i < n2; i++)
                right[i] = dizi[orta + 1 + i];

            int i1 = 0; // left index
            int i2 = 0; // right index
            int i3 = baslangic; // dizi index

            // Left ile Right Dizisini Karşılaştır
            while (i1 < n1 && i2 < n2)
            {
                if (Karsilastir(left[i1], right[i2], tur) > 0)
                {
                    dizi[i3] = left[i1];
                    i1++;
                }
                else
                {
                    dizi[i3] = right[i2];
                    i2++;
                }
                i3++;
            }

            // Left Dizisinde Kalan Olduysa Hepsini Yaz
            while (i1 < n1)
            {
                dizi[i3] = left[i1];
                i1++;
                i3++;
            }

            // Right Dizisinde Kalan Olduysa Hepsini Yaz
            while (i1 < n1)
            {
                dizi[i3] = right[i2];
                i2++;
                i3++;
            }

        }
    }
}
