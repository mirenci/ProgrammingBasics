using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class EqualWords
{
    static void Main()
    {
        string firstWord = Console.ReadLine();
        string secondWord = Console.ReadLine();

        string firstWordLowRegister = firstWord.ToLower();
        string secondWordLowRegister = secondWord.ToLower();

        if (firstWordLowRegister == secondWordLowRegister)
        {
            Console.WriteLine("yes");
        }
        else
        {
            Console.WriteLine("no");
        }
    }
}
