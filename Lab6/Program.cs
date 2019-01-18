using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //extended: Use the DiceRollerApp class to display special messags for craps, snake yes, and box cars.
            bool run = true;
            Console.WriteLine("Welcome to the Grand Circus Roll30 for DnD." + "\n");
            
            while (run == true)
            {
                int Dice1, Dice2;
                Console.Write("How many sides should each die have? (enter an integer):");
                int i = int.Parse(Console.ReadLine());
                Random roll = new Random();                
                Dice1 = DiceRoll(roll, i);
                
                Console.WriteLine("Your roll is: " + "\n" + Dice1);
                Dice2 = DiceRoll(roll, i);
                Console.WriteLine("Your roll is: " + "\n" + Dice2);
                if (Dice1==1 && Dice2==1)
                {
                    Console.WriteLine("You rolled Snake Eyes!");
                }
                else if (Dice1==6 && Dice2==6)
                {
                    Console.WriteLine("You rolled Boxcars!");
                }
                else if(Dice1+Dice2==7)
                {
                    Console.WriteLine("You rolled a Natural!");
                }

                
                Console.Write("Do you wish to roll the dice?(y/n):");
                string userInput;
                userInput = Console.ReadLine().ToLower();
                if (userInput == "y")
                {
                    run = true;
                }
                else if (userInput == "n")
                {
                    run = false;
                }
            }

        }
        public static int DiceRoll(Random roll, int i)
        {            
            int num = roll.Next(1, i+1);            
            return num;
        }
    }
}
