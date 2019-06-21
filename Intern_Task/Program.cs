using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intern_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write your input sentence : ");
            string name = Console.ReadLine();
            string[] tokens = name.Split(' ');
            int diff = 0;
            for (int i = 0; i < tokens.Length; i++)
            {
                if (i == 0)
                {
                    Console.WriteLine(tokens[i]); //first word remains as usual
                }
                else
                {
                    diff += tokens[i - 1].Length; //calculating number of spaces needed to make the pattern
                    for (int j = 0; j < diff; j++)
                    {                      
                        Console.Write(" "); //putting number of spaces before each word to form up the pattern
                    }
                    Console.WriteLine(tokens[i]);
                }
            }
            Console.ReadLine();
        }
    }
}
