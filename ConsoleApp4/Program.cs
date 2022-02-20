using System;
using System.Collections.Generic;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] nameArray = new string[3] { "zohreh", "kiana", "sara" };
            Random random = new Random();
            int x = random.Next(nameArray.Length);
            string name = nameArray[x];
            Console.WriteLine(name);
            

            int wrongNumber = 0;
            int rightNumber = 0;
            List<char> guessdList = new List<char>();
            while (wrongNumber != 10 && rightNumber != name.Length)

            {
                Console.Write("\r\n");

                Console.Write( "please insert your letter: ");
                char guess = Convert.ToChar(Console.ReadLine());
                bool right = false;

                foreach (char letter in name)

                {
                    if (guess == letter)
                    {
                        right = true;


                    }

                }
                if (right)
                {
                    rightNumber++;
                    guessdList.Add(guess);
                    Console.Write("\r\n");
                    int counter = 0;
                    foreach (char c in name)
                    {
                        if (guessdList .Contains (c))
                        {
                            Console.Write(c + " ");
                            Console.Write("\r\n");

                            foreach (char charac in name)
                            {
                                Console.Write("_ ");
                            }
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                        counter++;

                    }
                    



                }
                else
                {
                    Console.WriteLine("wrong");
                    wrongNumber++;
                    Console.WriteLine($"you have {10-wrongNumber} chanses.");
                    guessdList.Add(guess);
                }






            }


        }
    }
}
