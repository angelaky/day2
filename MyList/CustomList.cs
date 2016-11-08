using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyList
{
    //public delegate void ChangeDelegate(string input);

    public class CustomList
    {
        //public event ChangeDelegate OnChange;

        private static int currentID = 0;
        private int[] array;
        
        public CustomList()
        {
            this.array = new int[4];
        }


        public void Add(int element)
        {
            
            if (currentID >= array.Length)
            {
                var biggerArray = new int[currentID * 2];
                array.CopyTo(biggerArray, 0);
                array = biggerArray;
            }

            array[currentID] = element;
            currentID = currentID + 1;
            //string text = "Alabala";
            //this.OnChange(text);
        }

        public void Remove(int element)
        {
            int index = System.Array.IndexOf(array, element);
            var firsthalf = new int[array.Length -1];

            if (index > 0)
            {
                System.Array.Copy(array, 0, firsthalf, 0, index);
                System.Array.Copy(array, index + 1, firsthalf, index, array.Length - index - 1);
               // return true;
            }
            else if (index == 0)
            {
                System.Array.Copy(array, 1, firsthalf, 0, array.Length - 1);
               // return true;
            }
            else
            {
               // return false;
            }

            array = firsthalf;
        }

        public int GetElement(int index)
        {
            return array[index];
        }


    }
}
