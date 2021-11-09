using System;

namespace olympiaden_uppgift_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Double Kuvert = 0.074196;   // kuvert tot = 0.074196 * 2 /m^2
            Double affischer = 0.12474;
            Double informationsblad = 0.06237;
            Double vikt = 0;
            Double Kuvertvikt = 0;
            Double affischervikt = 0;
            Double infomationsvikt = 0;


            Console.WriteLine("Kuvert ? ");
            Kuvertvikt = int.Parse(Console.ReadLine());
            Console.WriteLine("affischer ? ");
            affischervikt = int.Parse(Console.ReadLine());
            Console.WriteLine("infomationsblad ? ");
            infomationsvikt = int.Parse(Console.ReadLine());
            
            
            
            vikt = ((Kuvertvikt*2 * Kuvert) + (affischer*2 * affischervikt) + (informationsblad * infomationsvikt));
            Console.WriteLine(vikt);
            



        }
    }
}
