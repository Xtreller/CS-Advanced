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
    public class ArrayCreator
    {
        public static T[] Create<T>(int length,T item)
        {
            T[] array = new T[length];

            for (int i = 0; i < length; i++)

            { array[i] = item; }

            return array;
        }
        
    }
    class EqualityScale<T>
    {
        private T left;
        private T right;

        public EqualityScale(T left ,T right)
        {
            this.left = left;
            this.right = right; 

        }

        public bool AreEqual()
        {
            bool result = this.left.Equals(this.right);

            return result;

        }




    }
}
