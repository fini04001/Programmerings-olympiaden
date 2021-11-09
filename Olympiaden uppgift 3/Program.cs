using System;

namespace Olympiaden_uppgift_2
{
    class Program
    {
        static void Main(string[] args)
        {
    
        Console.WriteLine("hur många med grönt kort?");
        int antalN = int.Parse(Console.ReadLine());
        Console.WriteLine("hur många utan grönt kort?");
        int antalM = int.Parse(Console.ReadLine());

        int tid = 10*(antalN/antalM+ 2*antalN/antalM); 
       
        Console.WriteLine(tid);

        }
    }
}
