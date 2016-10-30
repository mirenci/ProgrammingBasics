using System;

namespace _04.Triangle_of_55_Stars
{
    class TriangleOf55Stars
    {
        static void Main()
        {
            //foreach row
            for (int row = 0; row < 10; row++)
            {
                //height number of colunms(in current row) are equals of the current row number
                for (int column = 0; column <= row; column++)
                {
                    //put star in each column
                    Console.Write("*");
                }

                //start write in new line(row)
                Console.WriteLine();
            }
        }
    }
}
