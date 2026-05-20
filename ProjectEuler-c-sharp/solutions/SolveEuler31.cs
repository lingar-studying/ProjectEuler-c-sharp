using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler_c_sharp.solutions
{
    class SolveEuler31
    {

        public static int Solve(int[] coins, int r, int sum, 
            int currIdx, int count)
        {
            
            //base case
            if(sum== r)
            {
                return count + 1;
            }
            else if(sum > r)
            {
                return count;
            }


            //int newSum = sum;
            for(int i = currIdx; i < coins.Length; i++)
            {
                int newSum = sum + coins[i];
                count = Solve(coins, r, newSum, i, count);

            }


            return count;



        }

        public static void TrySolve()
        {
            int[] coins = {200,100,50,20,10,5,2,1 };
            int count = Solve(coins, 200, 0, 0, 0);

            Console.WriteLine("Result = " + count);
        }
    }
}
