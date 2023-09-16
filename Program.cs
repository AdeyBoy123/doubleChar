using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace doubleChar
{
    internal class Program
    {
        static string DoubleChar(string input)
        {
            char[] doubledChars = new char[input.Length * 2];

            for (int i = 0; i < input.Length; i++)
            {
                doubledChars[i*2] = input[i];
                doubledChars[i*2+1] = input[i];
            }

            return new string(doubledChars);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Input a string of your choice: ");
            string input = Console.ReadLine();

            string output = DoubleChar(input);

            Console.WriteLine("Result: " + output);

        }
    }
}
