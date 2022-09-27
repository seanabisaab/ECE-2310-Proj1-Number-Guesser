using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj1Guessnum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Random rand = new Random();
                int num = rand.Next(0, 101);
                while (true)
                {
                    Console.WriteLine("Guess the number!");
                    String inp = Console.ReadLine();
                    bool isNum = double.TryParse(inp, out double inpn);
                    if (isNum == false || (inpn % 1) != 0)
                    {
                        Console.WriteLine("Invalid Input!. Try again."); 
                    }
                    else if (inpn != num) { Console.WriteLine("Wrong Number! Try again."); }
                    else if (inpn == num)
                    {
                        Console.WriteLine("Correct! Would you like to play again?" +
                            "\n1. Yes" +
                            "\n2. No");
                        double i = Convert.ToDouble(Console.ReadLine());
                        if (i == 1)
                        {
                            Console.WriteLine("Get ready for round 2!");
                            break;
                        }
                        else if (i == 2)
                        {
                            Console.WriteLine("Thanks for playing! Come again soon.");
                            Environment.Exit(0);
                        }
                        else
                        {
                            Console.WriteLine("Invalid Input. Stopping Program.");
                            Environment.Exit(0);
                        }
                    }
                }
            }
        }
    }
}
