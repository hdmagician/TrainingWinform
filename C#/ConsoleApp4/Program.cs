using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    class TESTINT
    {
        private int[] array = new int[6];
        public int this[int index]
        {
            get { return array[index]; }
            set { array[index] = value; }
        }
    }
    class TEST
    {
        private string[] _array = new string[5];
        public string this[int index]
        {
            get { return _array[index]; }
            set { _array[index] = value; }
        }
        static void Main(string[] args)
        {
            TEST atest = new TEST();
            atest[0] = " 할룽a";
            atest[1] = " 할룽b";
            atest[2] = " 할룽c";
            atest[3] = " 할룽d";
            atest[4] = " 할룽e";
            for (int j = 0; j < 6; j++)
            {
                Console.WriteLine(atest[j]);
            }

            //배열을 다루는 클래스를 만드는거

            TESTINT atestint = new TESTINT();
            atestint[0] = 4562;
            atestint[1] = 2456;
            atestint[2] = 6245;
            atestint[3] = 5624;
            atestint[4] = 4562;
            atestint[5] = 2456;
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(atestint[i]);
            }
            

        }
    }
}