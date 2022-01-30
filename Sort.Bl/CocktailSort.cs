using System;

namespace Sort.Bl
{
    public class CocktailSort<T> : AlgorithmBase<T> where T: IComparable
    {
        protected override void MakeSort()
        {
            SwopCount = 0;
            int left = 0;
            int right = Items.Count - 1;
            while(left < right)
            {
                var sc = SwopCount;
                for (int i = left; i < right; i++)
                {
                    if (Items[i].CompareTo(Items[i + 1]) == 1)
                    {
                        Swop(i, i + 1);
                        СompareCount++;
                    }
                }
                right--;
                if (sc == SwopCount)
                {
                    break;
                }
                for (int i = right; i > left; i--)
                {
                    if (Items[i].CompareTo(Items[i - 1]) == -1)
                    {
                        Swop(i, i-1);
                        СompareCount++;
                    }
                }
                left++;
            }
        }
    }
}
