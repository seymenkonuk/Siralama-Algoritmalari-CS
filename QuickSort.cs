using System;

namespace Siralama_Algoritmalari_CS
{
    public static partial class SiralamaAlgoritmalari<T> where T : IComparable<T>
    {
        public static void QuickSort(T[] dizi, SiralamaTuru tur = SiralamaTuru.Ascending)
        {
            QuickSort(dizi, 0, dizi.Length - 1, tur);
        }
        private static void QuickSort(T[] dizi, int baslangic, int bitis, SiralamaTuru tur = SiralamaTuru.Ascending)
        {
            if (baslangic < bitis)
            {
                int partition = Partition(dizi, baslangic, bitis, tur);
                QuickSort(dizi, baslangic, partition - 1, tur);
                QuickSort(dizi, partition + 1, bitis, tur);
            }
        }
        private static int Partition(T[] dizi, int baslangic, int bitis, SiralamaTuru tur = SiralamaTuru.Ascending)
        {

            while (baslangic != bitis)
            {
                if (Karsilastir(dizi[bitis - 1], dizi[bitis]) > 0)
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
    }
}
