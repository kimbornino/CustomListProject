using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListProject
{
    public class CustomList<T> : IEnumerator<T>
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

        public static CustomList<T> operator +(CustomList<T> x, CustomList<T> y)
        {
            CustomList<T> tempList = new CustomList<T>();
            int firstListCount = tempList.Count;


            for (int i = 0; i < x.Count; i++)
            {
                tempList.Add(x[i]);
                firstListCount = tempList.Count + 1;

            }
            for (int i = 0; i < y.Count; i++)
            {
                tempList.Add(y[i + firstListCount]);

            }

            return tempList;
        }

        public static CustomList<T> operator -(CustomList<T> x, CustomList<T> y)
        {
            CustomList<T> tempList = new CustomList<T>();

            for (int i = 0; i < x.Count; i++)
            {
                for (int j = 0; j < y.Count; i++)
                {
                    if (i.Equals(j))
                    {

                    }
                    else
                    {
                        tempList.Add(x[i]);

                    }

                }

            }


            return tempList;
        }


        // public override string ToString(input)
        /*

public class Object2
    {
        private object value;

        public Object2(object value)
        {
            this.value = value;
        }

        public override string ToString()
        {
            return base.ToString() + ": " + value.ToString();
        }
    }

    public class Example
    {
        public static void Main()
        {
            Object2 obj2 = new Object2('a');
            Console.WriteLine(obj2.ToString());
        }
    }
    // The example displays the following output:
    //       Object2: a
    //{
    //return string;
    //} */
        /* public class CustomList<T> :
         {
             public CustomList<> list = new CustomList<T>();
             for (int i=0; i < CustomList.Count; i++)  
                 {
                 Console.WriteLine(list);
                 }
         //get Enumerator Method
         IEnumerator IEnumberable.GetEnumerator()
         {
             return (IEnumerator) GetEnumerator
         }
         public CustomList GetEnumerator()
         {
             return new CustomList(list);
         }
     } */
    }
}

    

   
    



