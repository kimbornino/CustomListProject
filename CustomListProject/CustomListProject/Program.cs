using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListProject
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomList<int> customList = new CustomList<int>();
            customList.Add(7);
            customList.Add(8);
            customList.Add(9);
            customList.Add(8);
            customList.Add(12);
            customList.Add(7);
            customList.Add(3);
            customList.Add(5);
            customList.Add(2);
            customList.Add(4);
            customList.Remove(2);


            for (int i = 0; i < customList.Count; i++)
            {
                Console.WriteLine(customList[i]);
                
            }
            Console.ReadLine();
        }
       
    }
}
