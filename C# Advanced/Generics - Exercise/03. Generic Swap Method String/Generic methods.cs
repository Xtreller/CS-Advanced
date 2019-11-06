using System;
using System.Collections.Generic;
using System.Text;

namespace Generics_Exercise
{
    class Generic_methods<T>
    {
        private List<string> collection;

        public Generic_methods()
        {
            this.collection = new List<string>();
        }
        public void Add(string item)
        {
            this.collection.Add(item);
        }
        public void Replace(int index0, int index1 )
        {
            string item = collection[index0];
            collection[index0] = collection[index1];
            collection[index1] = item;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var item in collection)
            {
                sb.AppendLine($"{item.GetType().FullName}: {item}");
            }
            
            return sb.ToString();
        }
    }
}
