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
            PrintSeparator("Favorite Characters Section");
            CharacterInfo("Spawn", AgeCalculator(1992));
            CharacterInfo("Ted Mosby", AgeCalculator(1978));
            CharacterInfo("Ultimate Warrior", AgeCalculator(1959));
            CharacterInfo("Marvin the Martian", AgeCalculator(1948));
            CharacterInfo("Himura Kenshin", AgeCalculator(1849));
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

            for (int i = size; i > 0; i--) //----------<| not working as intended
            {             
                Console.WriteLine(char1);
                char1.Substring(i, 1);
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
        static void CharacterInfo(string name, int birthYear)
        {
            Console.WriteLine($"{name} turns {birthYear} this year!");
        }
    }
}