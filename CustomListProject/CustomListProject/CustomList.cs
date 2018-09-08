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
        private int count;
        //Why won't this build when I try to use the variable "capactiy" inside of new array index.
        public int capacity;
        public T[] array;

        public CustomList()
        {
            count = 0;
            capacity = 10;
            array = new T[capacity];
        }
        //methods and properties
       
        public void Add(T input)
        {
            if (count >= capacity)
            {
                IncreaseCapacity();
            }
            array[count] = input;
            count = count + 1; 
        }

        //increase capacity needs to be able to double the space in array.  Will need to take the new array, copy
        public void IncreaseCapacity()
        {
            T[] tempArray = new T[capacity * 2];
            for (int i =0; i<capacity; i++)
            {
                tempArray[i] = array[i];
            }
            array = tempArray;
            capacity = capacity * 2;
  
        }
   
            
        // allow array (and list) to use indexer property
        public T this[int i]
        {
            get {
                return array[i];
            }
            set {
                array[i] = value;
                Console.WriteLine(value);
            }
        }

        // want to be able to count the total number of items in array.
        //Trying to figure out how what I'm supposed to "set".  How does this even work?
        public int Count
        {
            get { return count; }
            
            
        }

        public object Coun { get; set; }

        public void Remove()
        {

        }
    }
}
    

   
    



