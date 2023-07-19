using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTesting.Project
{
    public class NonInteger:Exception
    {

    }
    public class Negative : Exception
    {

    }
    public class SimpleParser
    {
        public int ParseAndSum(string numbers)
        {
            if (numbers.Length == 0)
            {
                return 0;
            }
            if (!numbers.Contains(","))
            {
                return int.Parse(numbers);
            }
            else
            {
                throw new InvalidOperationException("I can only handle 0 or 1 numbers for now!");
            }
        }

        public string NoRepeat(string target, char ch)
        {
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < target.Length; i++)
            {
                if (target[i] != ch)
                    result.Append(target[i]);
            }
            return result.ToString();
        }


        public bool isPrime(double prime)
        {

            if(prime == 1 || prime == 2)
            {
                return true;
            }
            if (Math.Floor(prime) != Math.Ceiling(prime))
                throw new NonInteger();



            if (prime < 0)
                throw new Negative();

            for(int i = 2; i < Math.Log(prime); i++)
            {
                if(prime % i == 0 && i != prime)
                {
                    return false;
                }
            }

            return true;
        }

    }
}
