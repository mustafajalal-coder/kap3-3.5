using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kap3_3._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
           


        
            
            {
                // Be användaren mata in två tal
                Console.Write("Skriv in det första talet: ");
                int tal1 = int.Parse(Console.ReadLine());

                Console.Write("Skriv in det andra talet: ");
                int tal2 = int.Parse(Console.ReadLine());

                // Visa menyn
                Console.WriteLine("Välj ett räknesätt:");
                Console.WriteLine("1. Addition");
                Console.WriteLine("2. Subtraktion");
                Console.WriteLine("3. Multiplikation");
                Console.WriteLine("4. Division");
                Console.Write("Ditt val: ");
                int val = int.Parse(Console.ReadLine());

                // Utför vald operation
                if (val == 1)
                {
                    Console.WriteLine($"Resultatet är: {tal1 + tal2}");
                }
                else if (val == 2)
                {
                    Console.WriteLine($"Resultatet är: {tal1 - tal2}");
                }
                else if (val == 3)
                {
                    Console.WriteLine($"Resultatet är: {tal1 * tal2}");
                }
                else if (val == 4)
                {
                    if (tal2 != 0)
                    {
                        Console.WriteLine($"Resultatet är: {tal1 / tal2}");
                    }
                    else
                    {
                        Console.WriteLine("Division med noll är inte tillåtet.");
                    }
                }
                else
                {
                    Console.WriteLine("Ogiltigt val.");
                }
            }
        }



    }
}

