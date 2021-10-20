using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhiteboardChallenges
{
    class Program
    {
        static void Main(string[] args)
        {
            FizzBuzz fizzBuzz = new FizzBuzz();
            fizzBuzz.runFizzBuzz();
            Console.ReadLine();
            Console.Clear();
            ReverseString reverseString = new ReverseString();
            reverseString.inputReverse();
            Console.ReadLine();
        }
    }
}
