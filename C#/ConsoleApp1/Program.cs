using System;
class Car
{
    // 속성(attribute)
    public int Speed = 0;// 속도: 숫자 => int
    const int SpeedValue = 10;
    const int SpeedLimit = 200;

    // 행위(behavior)
    public void Run()
    {
        Console.WriteLine("달립시다");
    }


    public void Accel()
    {
        Speed = Speed + SpeedValue;
        if(Speed > SpeedLimit)
        {
            Speed = SpeedLimit;
        }
        Console.WriteLine("현재 속력은 = {0}", Speed);
    }
    public void Break()
    {
        Speed = Speed - SpeedValue;
        if (Speed < 0)
        {
            Speed = 0;
        }
        Console.WriteLine(" 현재 속도는 {0}", Speed);
    }
}


class Auto
{
    static void Main(string[] args)
    {
        Car aCar = new Car();
        aCar.Accel();
        aCar.Accel();
        aCar.Accel();
        aCar.Break();
        aCar.Break();
        aCar.Break();
        aCar.Break(); // 0 이하인데도 0으로 출력
    }
}

