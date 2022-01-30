using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort.Bl
{
    public class AlgorithmBase<T>
    {
        public List<T> Items { get; set; } = new List<T>();
        protected void Swop(int positiona, int positionb)
        {
            if ((positiona < Items.Count) && (positionb < Items.Count))
            {
                var temp = Items[positiona];
                Items[positiona] = Items[positionb];
                Items[positionb] = temp;
            }
        }
        public virtual void Sort()
        {
            Items.Sort();
        }
    }
}
