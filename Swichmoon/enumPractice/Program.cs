using System;

struct SDAF//컨트롤 쉬프트 u 대문자로 변경함
{   //구조체는 =0 이게 안됨
    //상수 초기화 안됨
    // =0이 기본값임
    public int a;
    public int b;
}
//사용자 정의자료형
//class
//struct
//enum

//다른 언어에서는 정수형 상수 c#에서는 그냥 상수
enum Itemtype
{
    EQUIP,
    POTION,
    QUEST
}
class RPGitem
{
    Itemtype TYPE = Itemtype.EQUIP;
}

namespace enumPractice
{
    internal class Program
    {
        static void Test1(SDAF _data)
        {
            _data.a = 10000;
        }
        static void Main(string[] args)
        {
            SDAF NewData = new SDAF();
            NewData.a = 10;
            NewData.b = 10;

            Test1(NewData);//값이 초기화 되었기에 값이 바뀌지 않음
            Console.WriteLine(NewData.a);


            Console.ReadLine();
        }
    }
}
