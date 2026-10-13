using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace getset
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User Alecks = new User();
            Console.WriteLine("Please enter your Name:");
            Alecks.UserName = Console.ReadLine();

            Number Guess = new Number();
            Random random = new Random();

            bool value = false;

            Console.Clear();
            Console.WriteLine("Hello! " + Alecks.UserName + " welcome to the number guessing game!");
            Console.WriteLine("====================================================================");
            Console.WriteLine("Rules: ");
            Console.WriteLine("- You have 3 tries to guess the number");
            Console.WriteLine("- The number can only range from 0-9");
            Console.WriteLine("- There are hints at the bottom of the screen");
            Console.WriteLine("====================================================================");

            Guess.TargetNum = random.Next(10);

            for (int health = 0; health < 3; health++)
            {
                Console.WriteLine("Please enter a number: ");
                Guess.UserNum = Convert.ToInt32(Console.ReadLine());
                Guess.Hint = "";
                Console.WriteLine("Hint: " + Guess.Hint);
                Console.WriteLine(Guess.TargetNum);
                if (Guess.UserNum == Guess.TargetNum)
                {
                    value = true;
                    break;
                }
            }

            if (value)
            {
                Console.WriteLine("Congratulations for winning!");
            }
            else
            {
                Console.WriteLine("The number is: " + Guess.TargetNum);
            }

            Console.ReadKey();
        }
        public class User
        {
            public string UserName
            {
                get;
                set;
            }
        }

        public class Number
        {
           public int TargetNum { get; set; }
            public int UserNum { get; set; }

            public string hint;
            public string Hint
            {
                get
                {
                    return hint;
                }
                set
                {
                    if (UserNum > TargetNum)
                    {
                        hint = "A little lower!";
                    }
                    else
                    {
                        hint = "A little higher!";
                    }
                }
               
            }
        }
    }
}
