using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericListLast
{
    public class GenericList<T>
    {
        private T[] array;
        private int index;

        public GenericList()
        {
            this.index = 0;
            this.array = new T[2];
        }
        public void Add(T element)
        {
            array[index] = element;
            index++;
            if (index >= this.array.Length)
            {
                this.Resize();
            }
        }

        private void Resize()
        {
        }

        public T this[int index]
        {
            get { return this.array[index];}
            set { this.array[index] = value;}
        }
    }
}
