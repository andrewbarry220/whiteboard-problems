using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhiteboardChallenges
{
    //Fizz Buzz
    //Write a program that prints every number from 1 to 100 to the console
    //If a number is divisible by 3, print ‘fizz’ instead of the number
    //If a number is divisible by 5, print ‘buzz’ instead of the number
    //If a number is divisible by 3 and 5, print ‘fizzbuzz’ instead of the number
    class FizzBuzz
    {
        //member variables(has a)



        //constructor
        public FizzBuzz()
        {

        }
         
        
        //member methods(can do)
        public void runFizzBuzz()
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("fizzbuzz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("buzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("fizz");

                }
                else
                {
                    Console.WriteLine(i);
                    
                }
                
            }

        }
       
            

            


    }
}
