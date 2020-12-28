using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodingKatas.ProjectEuler.Problem023
{
    public class NonAbundantSums
    {
        public int[] GetDivisors(int number)
        {
            var results = new List<int>();

            int half = number / 2;

            for (int i = 1; i <= half; i++)
            {
                if (number % i == 0)
                    results.Add(i);
            }

            return results.ToArray();
        }

        public int SumDivisors(int[] divisors)
        {            
            return divisors.Sum();
        }

        public bool IsAbundant(int number, int sum) => sum > number;
        

        public List<int> FindAllAbundant()
        {
            int limit = 28123;
            List<int> abundantNumbers = new List<int>();

            for (int i = 1; i <= limit; i++)
            {
                var divisors = GetDivisors(i);
                var sumDivisors = SumDivisors(divisors);
                if (IsAbundant(i, sumDivisors))
                    abundantNumbers.Add(i);
            }
            return abundantNumbers;
        }

        public List<int> SumAbundants()
        {
            SortedSet<int> listOfSums = new SortedSet<int>();

            var allAbundants = FindAllAbundant();

            for (int i = 0; i < allAbundants.Count; i++)
            {
                for (int j = 0; j < allAbundants.Count; j++)
                {
                    int sum = allAbundants[i] + allAbundants[j];

                    if (sum > 28123)
                        break;
                    else
                        listOfSums.Add(sum);
                }
            }
            
            return listOfSums.ToList();
        }

        public int SumOfNonAbundants()
        {
            int limit = 28123;
            var list = SumAbundants();
            int sum = 0;
            for (int i = 1; i <= limit; i++)
            {
                if (list.Contains(i))
                    continue;
                else
                    sum += i;
            }
            return sum;
        }
    }
}
