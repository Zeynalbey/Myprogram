using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string firstCommand = Console.ReadLine();
                Console.WriteLine(MakeBigLetters(firstCommand));
                string secondCommand = Console.ReadLine();
                Console.WriteLine(MakeSmallLetters(secondCommand));
                string thirdCommand = Console.ReadLine();
                char letter = Convert.ToChar(Console.ReadLine());
                Console.WriteLine(FindBoolean(thirdCommand, letter));
            }
            static string MakeBigLetters(string forBig)
            {
                char[] smallLetters = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
                char[] bigLetters = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };

                for (int i = 0; i < forBig.Length; i++)
                {
                    for (int k = 0; k < smallLetters.Length; k++)
                    {
                        if (forBig[i] == smallLetters[k])
                        {
                            forBig = forBig.Replace(forBig[i], bigLetters[k]);
                        }
                    }
                }
                return forBig;
            }
            static string MakeSmallLetters(string forSmall)
            {
                char[] smallLetters = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
                char[] bigLetters = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };

                for (int i = 0; i < forSmall.Length; i++)
                {
                    for (int k = 0; k < bigLetters.Length; k++)
                    {
                        if (forSmall[i] == bigLetters[k])
                        {
                            forSmall = forSmall.Replace(forSmall[i], smallLetters[k]);
                        }
                    }
                }
                return forSmall;
            }
            static bool FindBoolean(string sentence, char letter)
            {
                for (int i = 0; i < sentence.Length; i++)
                {
                    if (sentence[i] == letter)
                    {
                        return true;
                    }
                }
                return false;
            }
        }
    }
}

