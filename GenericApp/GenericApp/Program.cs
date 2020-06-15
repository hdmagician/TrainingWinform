using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericApp
{
    class SimpleGeneric<T>
    {
        private T[] values;
        private int index;
        public SimpleGeneric(int len)   // 글자 길이를 보는거
        { 
            values = new T[len];
            index = 0;                   // 배열의 인덱스는 0으로 시작하니까 0으로 초기화
        }
        public void Add(params T[] args) // params : 파라미터가 들어가는 값
        {
            foreach (T e in args)        //foreach 딱 치고 탭을 2번 누르면 자동완성
                values[index++] = e;     // 배열을 만들고 하나씩 집어 넣는 것
        }
        public void Print()
        {
            foreach (T e in values)
                Console.Write(e + ", "); 
            Console.WriteLine();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            SimpleGeneric<Int32> gInteger = new SimpleGeneric<Int32>(10);
            SimpleGeneric<Double> gDouble = new SimpleGeneric<double>(10);

            gInteger.Add(1, 2);
            gInteger.Add(1, 2, 3, 4, 5, 6, 7);
            gInteger.Add(0);

            gDouble.Add(10.0, 12.4, 37.5);
            gInteger.Print();
            gDouble.Print();
        }
    }
}
