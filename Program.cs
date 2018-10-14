using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            string Continue; //Varible has to be delcared outside the loop because it is being used it outside the loop.  
            do
            {
                Console.WriteLine("Welcome to the Factorial Calculator");
                Console.WriteLine("Enter an integer that's greater than 0 but less than 20");
                int userInput = int.Parse(Console.ReadLine()); // setting the user input to an int.
                long factorial = 1; // long can hold larger values of variables. Had to be set to 1 to make mathmatical sense.


                for (int i = 0; i < userInput; i++) // "i" goes up everytimg you run it.
                {
                    factorial = (userInput - i) * factorial; // Using recursion, using a variable to effect itself, it caculates the factorial by using the pervious factorial. 

                }
                Console.WriteLine("The factorial of {0} is {1}", userInput, factorial); // Displays the factorial and the user input.

                do // prompts the user to continue only if the above is true
                {
                    Console.WriteLine("Would you like to Continue? (y/n)");
                    Continue = Console.ReadLine().ToLower();
                } while (Continue != "y" && Continue != "n");


            } while (Continue == "y");
            Console.WriteLine("Bye!");

        }
    }   
}
