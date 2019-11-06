using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace StartUP
{
    public class Box<T>
    {
        private List<T> item;

        private int count;

        public int Count
        {
            get
            {
                return this.item.Count;
            }
        }
        public Box()
        {
            item = new List<T>();

        }

        public void Add(T item)
        {
            this.item.Add(item);
        }
        public T Remove()
        {

            var rem = this.item.Last();

            this.item.RemoveAt(this.item.Count - 1);

            return rem;
        }






    }
}
