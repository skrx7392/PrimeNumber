using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            MainProg: 
            Console.WriteLine("Please enter an integer: ");
            int prime = int.Parse(Console.ReadLine());
            bool isPrime = CheckPrime(prime);
            if (isPrime)
            {
                Console.WriteLine(prime + " is a Prime Number. ");
            }
            else
            {
                Console.WriteLine(prime + " is not a Prime Number. ");
            }
            Console.WriteLine("Do you wish to check another number? (Y/N)");
            char nextChar = char.Parse(Console.ReadLine().ToUpper());
            if (nextChar == 'Y')
                goto MainProg;
            Console.WriteLine("Thank you!");
            System.Threading.Thread.Sleep(5000);
        }
        
        /// <summary>
        /// Function to check if the given number is prime
        /// </summary>
        /// <param name="prime">Takes in an integer as input parameter</param>
        /// <returns>Returns true if prime</returns>
        public static bool CheckPrime(int prime)
        {
            if(prime<2)
            {
                return false;
            }
            else if(prime==2)
            {
                return true;
            }
            else
            {
                for(int i=3; i<=Math.Sqrt(prime); i+=2)
                {
                    if(prime%i == 0)
                    {
                        return false;
                    }
                }
                return true;
            }
        }
    }
}
