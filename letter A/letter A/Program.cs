using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace letter_A
{
    class Program
    {
        void display(int n)
        {
            // Outer for loop for number of lines 
            for (int i = 0; i < n; i++)
            {
                // Inner for loop for logic execution 
                for (int j = 0; j <= n / 2; j++)
                {
                    // prints two column lines 
                    if ((j == 0 || j == n / 2) && i != 0 ||
                        // print first line of alphabet 
                        i == 0 && j != 0 && j != n / 2 ||
                        // prints middle line 
                        i == n / 2) {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("*");
                    }
                    else
                        Console.Write(" ");
                }

                Console.WriteLine();
            }
        }

        // Driver Function 
        static void Main(string[] args)
        {
            Program a = new Program();
            a.display(15);
            Console.Read();
        }
    }
}

