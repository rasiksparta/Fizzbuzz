using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fizzbuzz
{
    public class Fizzbuzz
    {
        public enum Output { Fizz, Buzz, Fizzbuzz }

        /**
         * Default constructor
         */
        public Fizzbuzz() { }

        /**
         * Constructor
         * @param startRange, the starting point from where the count begins 
         * @param endRange, the end point of the count
         */
        public Fizzbuzz(int startRange, int endRange) : this()
        {

        }

        /**
         * Check if a divident is divisible by a divisor without
         * producing any reminder
         * 
         * @param dividend
         * @param divisor
         * @return true, divisibility condition satisfies
         * @return false, divisibility condition is not satisfies
         */
        public bool Divisibility(int dividend, int divisor)
        {
            if (divisor > 0 && dividend % divisor == 0) return true;
            return false;
        }

        /**
         * Check if a dividend number is divisible by either 3, 5 or both 
         * out producing any remainder and return appropriate output
         * 
         * @param number, the dividend
         * @return fizz, if divisible by 3
         * @return buzz, if divisible by 5
         * @return fizzbuzz, if divisible by 3 and 5
         */
        public string SayFizzBuzz(int number)
        {
            if(Divisibility(number, 3) && Divisibility(number, 5))
            {
                return Output.Fizzbuzz.ToString();
            }
            else if(Divisibility(number, 3))
            {
                return Output.Fizz.ToString();
            }
            else if(Divisibility(number, 5))
            {
                return Output.Buzz.ToString();
            }
            return null;        
        }
    }
}
