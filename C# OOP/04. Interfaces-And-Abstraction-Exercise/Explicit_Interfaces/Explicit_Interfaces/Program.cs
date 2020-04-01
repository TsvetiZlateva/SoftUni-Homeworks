using System;

namespace Explicit_Interfaces
{
    class Program
    {


        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            while (input.ToLower() != "end")
            {
                var tokens = input.Split(" ");
                Citizen citizen = new Citizen(tokens[0], tokens[1], int.Parse(tokens[2]));
                IPerson p = citizen;
                Console.WriteLine(p.GetName()); 
                IResident r = citizen;
                Console.WriteLine(r.GetName()); 
                input = Console.ReadLine();
            }

        }
    }
}
