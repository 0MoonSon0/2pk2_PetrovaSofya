using System;

class Program
{
    static void Main()
    {
        string text = "";

        while (true)
        {
            string sentence = Console.ReadLine();
            if (sentence == "exit")
                break;

            text += sentence + " ";
        }

        Console.WriteLine(text);
    }
}