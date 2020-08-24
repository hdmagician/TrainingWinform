using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;

namespace _20200713_001
{
    class Program
    {
        static int Add (int N1, int N2)
        {
            return N1 + N2;
        }
        static void Main(string[] args)
        {
            int[] Array = { 144, 123, 232, 324, 789 };

            int index = System.Array.IndexOf(Array, 324);

            Console.WriteLine(index);

            for (int Count = 0; Count < Array.Length; ++Count)
            {
                if (Array[Count] == 3)
                {
                    Console.WriteLine("찾았다!! : " + Count);
                    break;
                }
            }
        }
    }
}
