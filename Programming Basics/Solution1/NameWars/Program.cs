using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameWars
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int maxSum = int.MinValue;
            string winnersName = "";

            while (name != "STOP")
            {
                int sum = 0;

                for (int i = 0; i < name.Length; i++)
                {
                    int num = name[i];
                    sum += num;

                        if (sum > maxSum)
                        {
                            maxSum = sum;
                            winnersName = name;
                        }
                }
                name = Console.ReadLine();
            }
            Console.WriteLine($"Winner is {winnersName} - {maxSum}!");
        }
    }
}
