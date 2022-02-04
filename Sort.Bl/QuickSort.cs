using System;

namespace Sort.Bl
{
    public class QuickSort<T> : AlgorithmBase<T> where T: IComparable
    {
        protected override void MakeSort()
        {
            QSort(0, Items.Count-1); 
        }
        private void QSort(int left, int right)
        {
            if (left >= right)
            {
                return;
            }
            var pivot = partition(left, right);
            QSort(left, pivot - 1);
            QSort(pivot + 1, right);
        }
        private int partition(int left, int right)
        {
            var pointer = left;
            //Опорный элемент находится под Right
            for (int i = left; i < right; i++)
            {
                if (Items[i].CompareTo(Items[right]) == -1)
                {
                    Swop(pointer, i);
                    pointer++;
                }
            }
            Swop(pointer, right);
            return pointer;
        }
    }
}