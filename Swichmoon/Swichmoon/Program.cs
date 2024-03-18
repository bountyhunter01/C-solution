using System;

namespace Swichmoon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            Console.WriteLine("숫자를 입력하시오");
            int switchTest = Convert.ToInt32(Console.ReadLine());//이거 중요함 
            switch (switchTest)
            {//상수만 비교가능
                case 0:
                    Console.WriteLine("0입니다");
                    break;
                case 1:
                    Console.WriteLine("1입니다");
                    break;
                case 100:
                    Console.WriteLine("100입니다");
                    break;
                default://else역할
                    Console.WriteLine("없는 숫자입니다");
                    break;
            }
            Console.ReadLine();

        }

    }
}
