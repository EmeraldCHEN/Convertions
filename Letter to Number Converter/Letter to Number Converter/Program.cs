using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Letter_to_Number_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n**********************************************");
            Console.WriteLine(" IF");
            Console.WriteLine(" A = 1");
            Console.WriteLine(" B = 2");
            Console.WriteLine(" C = 3");
            Console.WriteLine("  ...");
            Console.WriteLine(" X = 24");
            Console.WriteLine(" Y = 25");
            Console.WriteLine(" Z = 26");
            Console.WriteLine(" \nTHEN");

            ConvertLetters converter = new ConvertLetters();

            Console.WriteLine(" attitude is {0}%", converter.ConvertNumber("attitude"));

            Console.WriteLine(" hardwork is {0}%", converter.ConvertNumber("hardwork"));

            Console.WriteLine("\n**********************************************\n");

            Console.Write("Please enter a word:  ");

            string enteredWord = Console.ReadLine();

            Console.WriteLine("{0} is {1}%", enteredWord, converter.ConvertNumber(enteredWord));

            Console.ReadKey();
        }

       
    }
}
