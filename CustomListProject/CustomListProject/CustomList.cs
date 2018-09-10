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
        private int capacity;
        private T[] array;

        //constructor
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

        private void IncreaseCapacity()
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
            }
        }

        public int Count
        {
            get { return count; }
            
        }

        public void Remove(T input)
        {
            T[] tempArray = new T[capacity];
            int tempCount = 0;
            for (int i = 0; i < count; i++)
            {
                T index = array[i];
                T passedInput = input;
                if (index.Equals(passedInput))
                {
                    
                }
                else
                {
                    tempArray[tempCount] = array[i];
                    tempCount++;
                }
            }
            
            count = tempCount;
          
            array = tempArray;
        }
        //public override string ToString()
        //{
          
            //return base.ToString() + ": " + value.ToString();
        //}
    }
}
    

   
    



