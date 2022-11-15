using Bolens;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;

namespace Bolens
{
    
    public class Program
    {

        
        static void exit()
        {
            System.Environment.Exit(0);
        }
        static void Main(string[] args)
        {
            while (true)
            {
                string? userInput;
                Console.Write("mather>");
                userInput = Console.ReadLine();
                if (userInput == "bölenler")
                {
                    boling.bolens();
                }
                else if (userInput == "exit")
                {
                    exit();
                }
                if (userInput == "")
                {
                    Console.WriteLine("you didnt type anything!");
                }
                else
                {
                    Console.WriteLine("ü");
                }
                
            }
            
        }
    }
}