using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 100, y = 1, value = 0;
            
            try
            {
                value = x / y;
                Console.WriteLine($"{x} / {y} = {value}");
                // throw new Exception("사용자에러");
                // 정상적으로 실행되도 throw는 가능
            }
            catch (DivideByZeroException ex) // divide가 exception보다 위에
            {
                Console.WriteLine("2.y의 값을 0보다 크게 입력하세요.");
            }
            catch (Exception ex) // exception은 finally 바로 위에 있어야함
            {
                Console.WriteLine("3." + ex.Message);
                
            }
            finally 
            {
                Console.WriteLine("4. 프로그램이 종료했습니다.");
            }
        }
    }
}
