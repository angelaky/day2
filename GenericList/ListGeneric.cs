using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericList
{
    public class ListGeneric<T>
    {
        private static int currentID = 0;
        private T[] array;

        public ListGeneric()
        {
            this.array = new T[4];
        }


        public void Add(T element)
        {

            if (currentID >= array.Length)
            {
                var biggerArray = new T[currentID * 2];
                array.CopyTo(biggerArray, 0);
                array = biggerArray;
            }

            array[currentID] = element;
            currentID = currentID + 1;
            string text = "Alabala";
            //this.OnChange(text);
        }

        public int Remove(T element)
        {
            int index = System.Array.IndexOf(array, element);
            var firsthalf = new T[array.Length - 1];

            if (index > 0)
            {
                System.Array.Copy(array, 0, firsthalf, 0, index);
                System.Array.Copy(array, index + 1, firsthalf, index, array.Length - index - 1);
                array = firsthalf;
                return 1;
            }
            else if (index == 0)
            {
                System.Array.Copy(array, 1, firsthalf, 0, array.Length - 1);
                array = firsthalf;
                return 1;
            }
            else
            {
                return 0;
            }

            //array = firsthalf;
        }

        public T GetElement(int index)
        {
            return array[index];
        }

    }
}
