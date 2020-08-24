using System;

class Program
{
    static void ArrayIntPrint(int[] Num)
    {
        for (int Temp = 0; Temp < Num.Length; Temp++)
        {
            Console.Write("{0}", Num[Temp]);
        }
        Console.WriteLine();
    }
    static void Main(string[] args)
    {
        int[] Numbers1 = { 1, 3, 5, 7, 9 };
        ArrayIntPrint(Numbers1);

        

        //foreach  (int Temp in Numbers1)
        //{
        //    Console.Write("{0}", Temp);
        //}
        //Console.WriteLine();
    }
}

