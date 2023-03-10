/*
 * Author: Ron Jeremy Reyes
 * Course: COMP-003A
 * Purpose: Assignment for week 5
 */
namespace COMP003A.Assignment05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintSeparator("Triangle Section");
            /// <summary>
            /// Gets user input
            /// </summary>
            /// <param  name="char1">Character input</param>
            /// <param name="num1">Integer input</param>
            Console.Write("Enter a single character: ");
                char char1 = Convert.ToChar(Console.ReadLine());
            Console.Write("Enter a positive whole number: ");
                int num1 = Convert.ToInt32(Console.ReadLine());

            /// <summary>
            /// Calls Isosceles Triangle Builder Method
            /// </summary>
            IsoscelesTriangleBuilder(char1, num1);

            /// <summary>
            /// Calls Favorite Characters Method
            /// </summary>
            PrintSeparator("Favorite Characters Section"); //-----------------------<| FIXED lines 31-36
            CharacterInfo("Spawn", 1992);
            CharacterInfo("Ted Mosby", 1978);
            CharacterInfo("Ultimate Warrior", 1959);
            CharacterInfo("Marvin the Martian", 1948);
            CharacterInfo("Himura Kenshin", 1849);
        }

        /// <summary>
        /// Prints 50 "*"
        /// </summary>
        static void PrintSeparator()
        {
            Console.WriteLine("".PadRight(50, '*'));
        }

        /// <summary>
        /// Prints a text separator
        /// </summary> 
        /// <param name="separator">string input</param>
        static void PrintSeparator(string separator)
        {
            PrintSeparator();
            Console.WriteLine($"\t{separator}");
            PrintSeparator();
        }

        /// <summary>
        /// Creates a triangle based on the character input and size input
        /// </summary>
        /// <param name="inputCharacter"></param>
        /// <param name="size"></param>
        static void IsoscelesTriangleBuilder(char inputCharacter, int size)
        {
            string char1 = Convert.ToString(inputCharacter);
            
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine($"{char1}");
                char1 += inputCharacter;
            }

            for (int i = size - 1; i >= 0; i--) //----------------------------------<| FIXED lines 73-76
            {                             
                char1 = char1.Substring(0, i);
                Console.WriteLine(char1);
            }
        }

        /// <summary>
        /// Method for calculating age
        /// </summary>
        /// <param name="year"></param>
        /// <returns>Age</returns>
        static int AgeCalculator(int year)
        {
            return(DateTime.Now.Year - year);
        }

        /// <summary>
        /// Method for printing Character info and result of AgeCalculator method
        /// </summary>
        /// <param name="name"></param>
        /// <param name="birthYear"></param>
        static void CharacterInfo(string name, int birthYear) //--------------------<| FIXED lines 95-98
        {
            birthYear = AgeCalculator(birthYear);
            Console.WriteLine($"{name} turns {birthYear} this year!");
        }
    }
}