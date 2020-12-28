using CodingKatas.ProjectEuler.Problem023;
using System;

namespace CodingKatas
{
    class Program
    {
        static void Main( string[] args )
        {
            NonAbundantSums nonAbundant = new NonAbundantSums();

            //var list = nonAbundant.SumAbundants();

            //foreach (var item in list)
            //{
            //    Console.WriteLine(item);
            //}

            var sum = nonAbundant.SumOfNonAbundants();
            Console.WriteLine(sum);
        }
    }
}
