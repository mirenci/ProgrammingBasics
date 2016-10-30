using System;

class SquareOfStars
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int row = 0; row < n; row++)
        {
            if (row == 0 || row == n - 1)
            {
                for (int column = 0; column < n; column++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
            else
            {
                for (int column = 0; column < n; column++)
                {
                    if (column == 0 || column == n - 1)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }

                Console.WriteLine();
            }
        }
    }
}
