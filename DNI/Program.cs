using System;

namespace DNI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write your DNI/NIF number (Without the letter):");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("Your complete DNI/NIF is: " + number + LetterNIF(number));
        }

        /// <summary>
        /// This 
        /// </summary>
        /// <param name="number"></param>
        /// <returns> Letter </returns>
        public static char LetterNIF(int number)
        {
            Console.WriteLine("Write your DNI/NIF letter");
            char Letter= char.Parse(Console.ReadLine());
            return Letter;
        }
    }
}
