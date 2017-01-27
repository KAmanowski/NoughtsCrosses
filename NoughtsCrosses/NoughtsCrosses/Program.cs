using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoughtsCrosses
{
    class Program
    {
        static void Main(string[] args)
        {
            String Name;
            

            Console.WriteLine("Welocome to Noughts&Crosses");
            Console.WriteLine("Lets Start shall we?");
            Console.WriteLine("Type 'Y'to begin or type 'N' to exit");
            Console.ReadLine();
           if(Console.ReadLine() == Y)
            {
                Console.Clear();
                Console.WriteLine("Great! Lets get started!");
            }
           else if (Console.ReadLine() == N)
            {
                Console.WriteLine("Awe thats a shame! Maybe next time?!");
                Console.ReadLine();
                Environment.Exit;
            }



        
        }
    }
}
