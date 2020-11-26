using System;
using System.Collections.Generic;
using System.Text;

namespace CodingKatas.Ardalis.FizzBuzz
{
    public class FizzBuzzClass
    {

        public void FizzBuzz()
        {
            var fizzBuzzArray = FizzBuzzResultArray();

            for ( int i = 0; i < fizzBuzzArray.Length; i++ )
            {
                Console.WriteLine(fizzBuzzArray[i]);
            }
        }

        public string[] FizzBuzzResultArray()
        {
            string[] results = new string[100];

            for ( int i = 0; i < results.Length; i++ )
            {
                int currentNumber = i + 1;
                results[i] = currentNumber.ToString();

                if ( currentNumber % 3 == 0 )
                    results[i] = "Fizz";

                if ( currentNumber % 5 == 0 )
                    results[i] = "Buzz";

                if ( currentNumber % 3 == 0 && currentNumber % 5 == 0 )
                    results[i] = "FizzBuzz";


            }

            return results;
        }
    }
}
