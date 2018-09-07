using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListProject
{
    public class CustomList<T>
    {
        //member variables
        public T[] array = new T[10];
        private int count;

        //methods and properties
        //this is a property
        public void Add(T input)
        {

        }

        /*private public T[] IncreaseCapacity()
        {
            if (CustomList.Count > array.length) 
        {
              return new array
        }
        } */
        // Define the indexer to allow client code to use [] notation.
        public T this[int i]
        {
            get { return array[i]; }
            set { array[i] = value; }
        }
        public int Count
        {
            get { return count}
            set
            {
                {
                    //what IS this even?
                    //i++;
                    //return i;
                }
            }
        }
    }
}
    

   
    



