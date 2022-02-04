using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort.Bl
{
    public class MergeSort<T> : AlgorithmBase<T> where T: IComparable
    {
        private List<T> Sort(List<T> items)
        {
            if (items.Count == 1)
            {
                return items;
            }
            var mid = Items.Count / 2;
            var left = items.Take(mid).ToList();
            var right = items.Skip(mid).ToList();
            
            return Merge(Sort(left), Sort(right));
        }
        private List<T> Merge(List<T> left, List<T> right)
        {
            var lenght = left.Count + right.Count;
            var leftPtr = 0;
            var rightPtr = 0;
            var result = new List<T>();
            for (int i = 0; i < lenght; i++)
            {
                if (leftPtr < left.Count && rightPtr < right.Count)
                {
                    if (left[leftPtr].CompareTo(right[rightPtr]) == 1)
                    {
                        result.Add(left[leftPtr]);
                        leftPtr++;
                    }
                    else
                    {
                        result.Add(right[rightPtr]);
                        rightPtr++;
                    }
                }
                else
                {
                    if (rightPtr < right.Count)
                    {
                        result.Add(right[rightPtr]);
                        rightPtr++;
                    }
                    else
                    {
                        result.Add(left[leftPtr]);
                        leftPtr++;
                    }
                }
            }
            return result;
        }
        protected override void MakeSort()
        {
            Items = Sort(Items);
        }
    }
}