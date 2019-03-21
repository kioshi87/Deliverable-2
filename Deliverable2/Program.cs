using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deliverable2
    {
    class Program
    {
        private const string K = "Okay if you're in the mood for ";
        private const string L = ", then you should go to ";
        private const string H = ", then you should go ";
        private const string I = " and you should travel in ";
        private const string M = "!";
        private const string N = "action";
        private const string O = "chill times";
        private const string P = "danger";
        private const string J = "good food";

        static void Main(string[] args)
        {
            bool isError = false;

            Console.WriteLine("Hello User, What are you in the mood for?");
            
            string choice = "";

            do
            {
                isError = false;
                Console.WriteLine("Here are your options:");
                Console.WriteLine("1) Action");
                Console.WriteLine("2) Chill Times");
                Console.WriteLine("3) Danger");
                Console.WriteLine("4) Good Food");
                Console.WriteLine("Press 1,2,3 or 4");
                choice = Console.ReadLine();

                if (choice == "1")
                {
                    choice = N + H + "stock car racing";
                }
                else if (choice == "2")
                {
                    choice = O + H + "hiking";
                }
                else if (choice == "3")
                {
                    choice = P + H + "skydiving";
                }
                else if (choice == "4")
                {
                    choice = J + L + "Taco Bell";
                }
                else
                {
                    Console.WriteLine("Input not understood");
                    isError = true;
                }

            } while (isError);

          

            Console.WriteLine("How many people are you bringing with you?");

            string choice2 = "";

            do
            {

                isError = false;
                choice2 = Console.ReadLine();
                int C2 = Convert.ToInt32(choice2);


                if (C2 == 0)
                {
                    choice2 = "sneakers";
                }

                else if (C2 <= 4)
                {
                    choice2 = "a sedan";
                }

                else if (C2 <= 10)
                {
                    choice2 = "a Volkswagon bus";
                }

                else if (C2 >= 11)
                {
                    choice2 = "an airplane";
                }
                else if (choice2 == "")
                {
                    Console.WriteLine("Input not understood");
                    isError = true;
                }

            } while (isError);

            Console.WriteLine(K + choice + I + choice2 + M);
            Console.WriteLine("Goodbye.");
      

            Console.ReadKey();
        }
    }
}
