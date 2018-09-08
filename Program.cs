using System;

namespace Bangazon
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter string:");
            Console.Write(">>");
            var input = Console.ReadLine();

            var counter = 0;
            
            foreach(var letter in input)
            {
                if (counter == 0)
                {
                    Console.Write(letter.ToString().ToUpper() + "-");
                }
                else
                {
                    for (int i = 0; i <= counter; i++) {
                        if (i == 0) {
                            Console.Write(letter.ToString().ToUpper());
                        } 
                        else
                        {
                            Console.Write(letter);
                        }

                        Console.Write("-");
                    }
                }
                
                counter++;
            }

            Console.WriteLine("");
            Console.WriteLine("Press enter to quit.");
            Console.ReadLine();
        }
    }
}
