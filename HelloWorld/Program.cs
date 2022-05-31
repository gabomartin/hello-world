using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
     class Program
     {
        static void Main(string[] args)
        {
            float f = 2.1F;
            int i = (int)Math.Ceiling(f);
            Console.WriteLine("ORIGINAL " + f);
            Console.WriteLine("REDONDEADO " + i);
            

            List<int> list = new List<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);
            list.Add(6);
            list.Add(7);
            list.Add(8);
            list.Add(9);
            list.Add(10);


            List<List<int>> list2 = list.ChunkBy<int>(5); //el mejor extension method de la historia

            foreach(List<int> item in list2)
            {
                Console.WriteLine("Tengo: " + item.Count());
            }

            Console.ReadLine();






        }
     }

}
