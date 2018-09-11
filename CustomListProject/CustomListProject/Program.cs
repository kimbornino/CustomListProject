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
            CustomList<string> onions = new CustomList<string>();
            onions.Add("2");
            onions.Add("3");
            onions.Add("4");

            CustomList<string> lemon = new CustomList<string>();
            lemon.Add("yes");
            lemon.Add("no");
            lemon.Add("sure");
            lemon.Add("whynot");
            lemon.Add("iguess");

            CustomList<string> result = CustomList<string>.Zip(lemon,onions);


            Console.WriteLine(result);

            
            foreach (string banana in onions)
            {
                Console.WriteLine (banana);
                Console.ReadKey();
            }
            foreach (string banana in onions)
            {
                Console.WriteLine(banana);
                Console.ReadKey();
            }

            
            

        }
       
    }
}
