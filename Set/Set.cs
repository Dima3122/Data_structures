using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Set
{
    public class Set<T>
    {
        private List<T> items = new List<T>();
        public int Count => items.Count;      
        public Set() { }
        public void Add(T item)
        {
            if (items.Contains(item))
            {
                return;
            }
            items.Add(item);
        }
        public void Remove(T item)
        {
            items.Remove(item);
        }
        public Set<T> Union(Set<T> set)
        {
            Set<T> result = new Set<T>();
            
            foreach (var item in items)
            {
                 result.Add(item);
            }   
            foreach (var item in set.items)
            {
                result.Add(item);
            }

            return result;
        }
    }
}
