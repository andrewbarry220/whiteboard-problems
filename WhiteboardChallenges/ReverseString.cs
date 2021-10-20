using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhiteboardChallenges
{
       
    class ReverseString
    {
        //Reverse a string whiteboard problem
        //Write code that takes a string as input and returns the string reversed
        //i.e. “Hello” will be returned as “olleH”


        //member variables (has a)
        public string userInput1;
        public int userInput2;
       


        //constructor
        public ReverseString()
        {

        }

        //methods (can do)
        //Will ask the user for a string input and then take that string and reverse the input string and then display that string        

        public void inputReverse()
        {
            Console.WriteLine("Please enter a word for the system to reverse");
            userInput1 = Console.ReadLine();

            //check to see if the user did not enter anything into the prompt. If nothing entered give error and then restart the method

            if (string.IsNullOrEmpty(userInput1))
            {
                Console.WriteLine("You did not enter anything");
                Console.ReadLine();
                Console.Clear();
                inputReverse();
            }
            //if user inputs a number reject it and let them know it was not a word and restart the method

            else if (int.TryParse(userInput1, out userInput2))
            {
                Console.WriteLine("That is not a word");
                Console.ReadLine();
                Console.Clear();
                inputReverse();
            }

            //If a word was correctly entered, take the word and reverse it. Converted the user input to an array and then reversed it and stored it
            //into userInput1. Wrote userInput out to the user. 

            else
            {
                char[] charArray = userInput1.ToCharArray();
                Array.Reverse(charArray);
                userInput1 = new string(charArray);
                Console.WriteLine(charArray);
                

            }
               
        }
        //public void stringReverse(string str)
        //{
        //    
        //}


    }
}
