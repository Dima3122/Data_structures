﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Sort.Bl
{
    public class BubleSort<T> : AlgorithmBase<T> where T : IComparable
    {
        protected override void MakeSort()
        {
            SwopCount = 0;
            var count = Items.Count;
            for (int j = 0; j < count; j++)
            {
                for (int i = 0; i < count - j - 1; i++)
                {
                    var a = Items[i];
                    var b = Items[i + 1];
                    СompareCount++;
                    if (a.CompareTo(b) == 1)
                    {
                        Swop(i, i + 1);
                    }
                }
            }
        }
    }
}
