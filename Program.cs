using System;

namespace uppgift
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in hur lång din låt är, skriv först hur många minuter och sedan sekunder.");
            Console.WriteLine("Gränsen för att din låt ska kunna vara med på radiostationen är att den ska vara under 4 minuter och 20 sekunder");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Skriv i HELTAL");
            Console.ForegroundColor= ConsoleColor.White;
            int minuter = int.Parse(Console.ReadLine())*60;
            Console.WriteLine("Skriv nu in sekunderna");
            int sekunder = int.Parse(Console.ReadLine());

            int gräns = 240 + 20;


            if (minuter + sekunder < 260)
            {
                Console.WriteLine("Din låt får vara med på radiostationen!");
            }
            else
            {
                Console.WriteLine("Din låt får inte vara med på radiostationen för den är för lång.");
            }
            Console.ReadKey();
        }
    }
}