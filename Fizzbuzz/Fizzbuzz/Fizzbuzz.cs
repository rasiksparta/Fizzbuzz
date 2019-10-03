using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fizzbuzz
{
    public class Fizzbuzz
    {
        enum Output { Fizz, Buzz, Fizzbuzz }

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
    }
}
