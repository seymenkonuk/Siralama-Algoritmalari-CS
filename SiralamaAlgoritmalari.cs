using System;

namespace Siralama_Algoritmalari_CS
{
    public enum SiralamaTuru
    {
        Descending,
        Ascending
    }
    static class SiralamaAlgoritmalari<T> where T : IComparable<T>
    {
        private static int Karsilastir(T item1, T item2, SiralamaTuru tur = SiralamaTuru.Ascending)
        {
            if (tur == SiralamaTuru.Ascending)
                return item1.CompareTo(item2);
            return item2.CompareTo(item1);
        }
        static public void BubbleSort(T[] dizi, SiralamaTuru tur = SiralamaTuru.Ascending)
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
        static public void SelectionSort(T[] dizi, SiralamaTuru tur = SiralamaTuru.Ascending)
        {
            for (int i = 0; i < dizi.Length - 1; i++)
                for (int j = i + 1;  j < dizi.Length; j++)
                    if (Karsilastir(dizi[i], dizi[j], tur) > 0)
                    {
                        T depo = dizi[j];
                        dizi[j] = dizi[i];
                        dizi[i] = depo;
                    }
        }
        static public void InsertionSort(T[] dizi, SiralamaTuru tur = SiralamaTuru.Ascending)
        {
            for (int i = 1; i < dizi.Length; i++)
            {
                for (int j = i - 1; j >= 0; j--)
                    if (Karsilastir(dizi[j], dizi[j+1], tur) > 0)
                    {
                        T depo = dizi[j];
                        dizi[j] = dizi[j+1];
                        dizi[j+1] = depo;
                    }
                    else
                    {
                        break;
                    }
            }
        }
        static public void QuickSort(T[] dizi, SiralamaTuru tur = SiralamaTuru.Ascending)
        {
            QuickSort(dizi, 0, dizi.Length - 1, tur);
        }
        static private void QuickSort(T[] dizi, int baslangic, int bitis, SiralamaTuru tur = SiralamaTuru.Ascending)
        {
            if (baslangic < bitis)
            {
                int partition = Partition(dizi, baslangic, bitis, tur);
                QuickSort(dizi, baslangic, partition - 1, tur);
                QuickSort(dizi, partition + 1, bitis, tur);
            }
        }
        static private int Partition(T[] dizi, int baslangic, int bitis, SiralamaTuru tur = SiralamaTuru.Ascending)
        {

            while (baslangic != bitis)
            {
                if (Karsilastir(dizi[bitis-1], dizi[bitis]) > 0)
                {
                    T depo = dizi[bitis];
                    dizi[bitis] = dizi[bitis - 1];
                    dizi[bitis - 1] = depo;
                    bitis--;
                } 
                else
                {
                    T depo = dizi[baslangic];
                    dizi[baslangic] = dizi[bitis - 1];
                    dizi[bitis - 1] = depo;
                    baslangic++;
                }
            }

            return baslangic;
        }
        static public void CountingSort(byte[] dizi, SiralamaTuru tur = SiralamaTuru.Ascending)
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
        static public void MergeSort(T[] dizi, SiralamaTuru tur = SiralamaTuru.Ascending)
        {
            MergeSort(dizi, 0, dizi.Length - 1, tur);
        }
        static private void MergeSort(T[] dizi, int baslangic, int bitis, SiralamaTuru tur)
        {
            if (baslangic < bitis)
            {
                int orta = (baslangic + bitis) / 2;
                MergeSort(dizi, baslangic, orta, tur);
                MergeSort(dizi, orta + 1, bitis, tur);
                Merge(dizi, baslangic, orta, bitis, tur);
            }
        }
        static private void Merge(T[] dizi, int baslangic, int orta, int bitis, SiralamaTuru tur)
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
