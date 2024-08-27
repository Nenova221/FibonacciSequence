using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciSequence
{
    public class FibonacciNumbers
    {
        public static void PrintFibonacciSequence(int count)
        {
            long firstNumber = 0;
            long secondNumber = 1;
            Console.WriteLine(firstNumber);
            Console.WriteLine(secondNumber);
            for (int i = 2; i < count; i++)
            {
                long nextNumber = firstNumber + secondNumber;
                Console.WriteLine(nextNumber);
                firstNumber = secondNumber;
                secondNumber = nextNumber;
            }
        }
        public static long[] GetFibonacciSequence(int count)
        {
            long[] sequence = new long[count];
            if (count > 0) sequence[0] = 0;
            if (count > 1) sequence[1] = 1;
            long firstNumber = 0;
            long secondNumber = 1;
            for (int i = 2; i < count; i++)
            {
                long nextNumber = firstNumber + secondNumber;
                sequence[i] = nextNumber;

                firstNumber = secondNumber;
                secondNumber = nextNumber;
            }
            return sequence;
        }
    }
}