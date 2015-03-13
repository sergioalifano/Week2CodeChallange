using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_2_Code_Challange
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 20; i++)
            {
                FizzBuzz(i);
            }

            string s1 = "I love biscuits and gravy. It’s the best breakfast ever";
            string s2= "Never gonna give you up. Never gonna let you down";
            string s3="Sally sells seashells down by the seashore. She’s from Sussex";

            LetterCounter('i', s1);
            LetterCounter('n', s2);
            LetterCounter('s', s3);

            Console.ReadKey();
        }

        static void FizzBuzz(int number)
        {
            //if number is dividible by 3
            if (number % 3 == 0 && number % 5 != 0)
            {
                Console.WriteLine("Buzz");
            }
            //if number is dividible by 3 and 5
            else if (number % 3 == 0 && number % 5 == 0)
            {
                Console.WriteLine("FizzBuzz");
            }
            //if number is dividible for 5
            else if (number % 3 != 0 && number % 5 == 0)
            {
                Console.WriteLine("Fizz");
            }

            else
            {
                Console.WriteLine(number);
            }
        }

        /// <summary>
        /// Count the number of instances of a letter in a string
        /// </summary>
        /// <param name="letter">the letter to look for</param>
        /// <param name="inString">the string where to look</param>
        static void LetterCounter(char letter, string inString)
        {
            int isUpper = 0;
            int isLower = 0;
            int totalFound=0;

            //loop through the string
            for (int i = 0; i < inString.Length; i++)
            {
                //case insensitive
                if (inString[i].ToString().ToUpper() == letter.ToString().ToUpper())
                {
                    if (char.IsUpper(inString[i]))
                    {
                        isUpper++;
                        totalFound++;
                    }
                    else
                    {
                        isLower++;
                        totalFound++;
                    }
                }
            }

            Console.WriteLine("Input: " + inString);
            Console.WriteLine("Number of lowercase {0}'s found: {1}",letter,isLower );
            Console.WriteLine("Number of UPPERCASE {0}'s found: {1}", letter, isUpper);
            Console.WriteLine("Total number of {0}'s found: {1} ",letter,totalFound);
        }
    }
}
