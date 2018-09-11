using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListProject
{
    public class CustomList<T> : IEnumerable
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
            for (int i = 0; i < capacity; i++)
            {
                tempArray[i] = array[i];
            }
            array = tempArray;
            capacity = capacity * 2;

        }

        // allow array (and list) to use indexer property
        public T this[int i]
        {
            get
            {
                return array[i];
            }
            set
            {
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

        public IEnumerator<T> GetEnumerator()
        {
            for (int index = 0; index < this.Count; index ++)
            {
                yield return this[index];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

                   
        public static CustomList<T> operator +(CustomList<T> x, CustomList<T> y)
        {
            CustomList<T> tempList = new CustomList<T>();
            int firstListCount = tempList.Count;

            for (int i = 0; i < x.Count; i++)
            {
                tempList.Add(x[i]);
            }
            for (int i = 0; i < y.Count; i++)
            {
                tempList.Add(y[i]);

            }

            return tempList;
        }

        public static CustomList<T> operator -(CustomList<T> x, CustomList<T> y)
        {
            //CustomList<T> tempList = new CustomList<T>();

            for (int i = 0; i < x.Count; i++)
            {
                for (int j = 0; j < y.Count; j++)
                {
                    if (x[i].Equals(y[j]))
                    {
                        x.Remove(x[i]);
                        
                    }
                }               
            }
            return x;
        }

       public override string ToString()  
        {
            string newString = "";
            foreach (T value in this)
            {
               string tempString = value.ToString();
                newString += tempString;
                newString += " , ";
            }
                return newString;
            //{
                //templist.Add.ToString(listToChange[i]);
               
            //}
            
            //return tempList;
               
        }
        public static CustomList<T> Zip(CustomList<T> odd, CustomList<T> even)
        {
            CustomList<T> newList = new CustomList<T>();
            int j = 0;

            for (int i = 0; i < odd.Count; i++)
            {
                newList.Add(odd[i]);
                while ( j < even.Count) 
                {
                    newList.Add(even[j]);
                    j++;
                    break;
                }
            }
            return newList;
        }
    }
}

    

   
    



