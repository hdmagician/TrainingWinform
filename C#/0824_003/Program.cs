﻿using System;


namespace _0824_003
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            Console.WriteLine("{0, -16}", "Random Bytes");
            Byte[] b = new byte[5];
            r.NextBytes(b);  // 한번의 호출값으로 랜덤 값을 채움

            foreach (var x in b)
            {
                Console.WriteLine("{0,12}", x); //12자리로 출력
            }
            Console.WriteLine();

            Console.WriteLine("{0, -16}", "Random Double"); 
            double[] d = new double[5];

            for (int i = 0; i < 5; i++)
            {
                d[i] = r.NextDouble();
            }

            foreach (var x in d)
            {
                Console.WriteLine("{0, 12:F8}", x); // 12자리 소수점아래 8자리로 출력
            }Console.WriteLine();


            Console.WriteLine("{0, -16}", "Random Int32");
            int[] a = new int[5];

            for (int i = 0; i < 5; i++) // 5개의 int랜덤값을 자동생성
            {
                a[i] = r.Next();
            }
            PrintArray(a);
        }

        private static void PrintArray(int[] v)
        {
            foreach (var value in v)
            {
                Console.WriteLine("{0,12}", value);
            }
            Console.WriteLine();
        }
    }
}
