using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++) 
            {
                if (i % 2 != 0) //Computer turn
                {
                    if (IsFizzBuzz(i)) { Console.WriteLine("FizzBuzz"); }
                    else if (IsFizz(i)) { Console.WriteLine("Fizz"); }
                    else if (IsBuzz(i)) { Console.WriteLine("Buzz"); }
                    else { Console.WriteLine(i); }
                }
                else //User turn
                {
                    String userTurn = Console.ReadLine();
                    bool success = int.TryParse(userTurn, out int j);

                    //if correct, continue, else end
                    if (userTurn.ToUpper() == "FIZZBUZZ" && IsFizzBuzz(i)) { }
                    else if (userTurn.ToUpper() == "FIZZ" && IsFizz(i)) { }
                    else if (userTurn.ToUpper() == "BUZZ" && IsBuzz(i)) { }
                    else if (success == true && j == i) 
                    {
                        if (IsBuzz(i) || IsFizz(i) || IsFizzBuzz(i)) 
                        {
                            Incorrect();
                            break;
                        }
                    }
                    else
                    {
                        Incorrect();
                        break;
                    }
                }
            } //end of for loop   
            Console.ReadLine(); //don't immediately close window
        }

        public static void Incorrect() 
        {
            Console.WriteLine("Incorrect! Please play again!");
        }

        public static bool IsFizzBuzz(int i) 
        {
            bool isFizzBuzz = false; 
            if (IsFizz(i) && IsBuzz(i)) { isFizzBuzz = true; }
            return isFizzBuzz;
        }

        public static bool IsFizz(int i)
        {
            bool isFizz = false;
            if (i % 3 == 0) { isFizz = true; }
            return isFizz;
        }

        public static bool IsBuzz(int i)
        {
            bool isBuzz = false;
            if (i % 5 == 0) { isBuzz = true; }
            return isBuzz;
        }


    }
    
}
