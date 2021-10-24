using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    public class CoinSums
    {
        public int[] Coins = new int[] { 1, 2, 5, 10, 20, 50, 100, 200 };

        public int Run(int target)
        {
            int[][] table = new int[target + 1][];
            int i = 0;
            for (i = 0; i <= target; i++)
            {
                table[i] = new int[Coins.Length];
                table[i][0] = 1;
            }
            
            int j = 0;
            for (i = 0; i <= target; i++)
            {
                for(j = 1; j < Coins.Length; j++)
                {
                    table[i][j] = table[i][j - 1];
                    if (Coins[j] <= i)
                        table[i][j] += table[i - Coins[j]][j];
                }
            }

            return table[i - 1][j - 1];
        }
    }
}
