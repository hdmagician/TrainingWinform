using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        class Car
        {
            string color;
            string vender; // 제조사
            string name;

            public Car()
            {
                Console.WriteLine("Car 생성자 호출");
            }

            ~Car()
            {
                Console.WriteLine("Car 소멸자 호출");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("1=================");
            Car aCar = new Car();
            new Car();
            Console.WriteLine("2=================="); 
        }
    }
}
