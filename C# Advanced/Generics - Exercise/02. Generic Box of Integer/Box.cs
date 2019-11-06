using System.Collections.Generic;
using System.Text;

namespace Generics_Exercise
{
     class Box<T>
    {
        private List<int> collection;

        public Box()
        {
            this.collection = new List<int>();
        }
        public void Add(int item)
        {
            this.collection.Add(item);
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var item in this.collection)
            {
                sb.AppendLine($"{item.GetType().FullName}: {item}"); 
            }
            return sb.ToString();

        }
    }
}