using System;

//Task 09
class PasswordGuess
{
    static void Main()
    {
        string inputValue = Console.ReadLine();
        string password = "s3cr3t!P@ssw0rd";

        //iterate string by character
        for (int i = 0; i < inputValue.Length; i++)
        {
            if (inputValue[i] != password[i])
            {
                Console.WriteLine("Wrong password!");
                return;
            }
            else if (i == inputValue.Length - 1)
            {
                Console.WriteLine("Welcome");
            }
        }
    }
}
