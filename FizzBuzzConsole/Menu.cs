using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzConsole
{
    public class Menu
    {
        class MainProgram
        {
            static void Main(string[] args)
            {
                int choice;
                string result = ""; // Flyttade deklarationen av result och gav den ett initialt värde

                do
                {
                    Console.WriteLine("Välj ett alternativ:");
                    Console.WriteLine("1. Anropa FizzBuzz för siffrorna 1-100");
                    Console.WriteLine("2. Anropa FizzBuzz för en valfri siffra");
                    Console.WriteLine("0. Avsluta");
                    Console.Write("Val: ");
                    choice = Convert.ToInt32(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("Resultat för siffrorna 1-100:");
                            for (int i = 1; i <= 100; i++)
                            {
                                result = FizzBuzzApplication.FizzBuzz(i);
                                Console.WriteLine(result);
                            }
                            break;
                        case 2:
                            Console.Write("Ange en siffra: ");
                            int number = Convert.ToInt32(Console.ReadLine());
                            result = FizzBuzzApplication.FizzBuzz(number);
                            Console.WriteLine("Resultat: " + result);
                            break;
                        case 0:
                            Console.WriteLine("Programmet avslutas.");
                            break;
                        default:
                            Console.WriteLine("Ogiltigt val. Försök igen.");
                            break;
                    }

                    Console.WriteLine();
                } while (choice != 0);
            }
        }
    }
}
