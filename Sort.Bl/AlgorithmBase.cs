using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort.Bl
{
    public class AlgorithmBase<T>
    {
        public List<T> Items { get; set; } = new List<T>();
        public int SwopCount { get; protected set; } = 0;
        public int СompareCount { get; protected set; } = 0;
        protected void Swop(int positiona, int positionb)
        {
            if ((positiona < Items.Count) && (positionb < Items.Count))
            {
                var temp = Items[positiona];
                Items[positiona] = Items[positionb];
                Items[positionb] = temp;

                SwopCount++;
            }
        }
        public TimeSpan Sort()
        {
            var timer = new Stopwatch();
            SwopCount = 0;
            timer.Start();
            MakeSort();
            timer.Stop();
            return timer.Elapsed;
        }
        protected virtual void MakeSort()
        {
            Items.Sort();
        }
    }
}
