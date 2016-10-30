using System;

/*
 Task 12
 Да се напише програма, която въвежда скорост (десетично число) и отпечатва информация за скоростта. 
 При скорост до 10 (включително) отпечатайте “slow”. 
 При скорост над 10 и до 50 отпечатайте “average”. При скорост над 50 и до 150 отпечатайте “fast”. 
 При скорост над 150 и до 1000 отпечатайте “ultra fast”. При по-висока скорост отпечатайте “extremely fast”. 
 */
class SpeedInfo
{
    static void Main()
    {
        float speed = float.Parse(Console.ReadLine());

        if (speed <= 10)
        {
            Console.WriteLine("slow");
        }
        else if (speed > 10 && speed <= 50)
        {
            Console.WriteLine("average");
        }
        else if (speed > 50 && speed <= 150)
        {
            Console.WriteLine("fast");
        }
        else if (speed > 150 && speed <= 1000)
        {
            Console.WriteLine("ultra fast");
        }
        else
        {
            Console.WriteLine("extremely fast");
        }
    }
}
