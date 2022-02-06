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
        public Stopwatch timer = new Stopwatch();
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
        public event EventHandler AlgorithmComplited;
        public async void Sort()
        {
            SwopCount = 0;
            timer.Start();
            await Task.Run(() => MakeSort());
            timer.Stop();
            AlgorithmComplited?.Invoke(this, null);
        }
        protected virtual void MakeSort()
        {
            Items.Sort();   
        }
    }
}
