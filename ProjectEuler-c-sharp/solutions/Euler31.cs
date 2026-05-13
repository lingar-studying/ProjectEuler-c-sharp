using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler_c_sharp.solutions
{
    public class Euler31
    {

        public static void SolveZeroProblem(long upperBound)
        {

            long i = 1;
            long sum = 0;
            while(i <= upperBound)
            {
                //Console.WriteLine("hello 1" +i);

                long result = i * i;
                if (result % 2 != 0) sum += result;
                i+=2;

            }
            Console.WriteLine("Total sum = " + sum);

        }

        public static int SolveEuler31()
        {
            //add the biggest value and add it.
            //if the sum is lower than R - continue again
            //if the sum is higher than R return to last and lower down the coin value
            //if the sum == R - summerize the sum and return to last
            int sum = 0;
            int r = 200;
            int count = 0;
            
            if(sum >= r)
            {

            }

            if(sum <= r)
            {

            }

            if (sum == r)
            {
                return count++;
            }

            else if (sum > r)
                return count;

            else
            {
                return count;
            }


        }
    }
}
