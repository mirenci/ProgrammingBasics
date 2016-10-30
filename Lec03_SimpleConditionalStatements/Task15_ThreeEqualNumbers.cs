using System;

/*
 Task 15
 * Три еднакви числа: да се въведат 3 числа и да се отпечата дали са еднакви (yes / no).
 */
class ThreeEqualNumbers
{
    static void Main()
    {
        int firstNumber = int.Parse(Console.ReadLine());
        int secondNumber = int.Parse(Console.ReadLine());
        int thirdNumber = int.Parse(Console.ReadLine());

        if (firstNumber == secondNumber && secondNumber == thirdNumber)
        {
            Console.WriteLine("yes");
        }
        else
        {
            Console.WriteLine("no");
        }
    }
}
