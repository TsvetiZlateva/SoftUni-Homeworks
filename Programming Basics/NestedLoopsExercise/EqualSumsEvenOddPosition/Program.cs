using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualSumsEvenOddPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int num1 = int.Parse(Console.ReadLine());
            int newNumber = num;

            while (newNumber <= num1)
            {
                for (int i = 0; i <= 9; i++)
                {
                    for (int j = 0; j <= 9; j++)
                    {
                        for (int k = 0; k <= 9; k++)
                        {
                            for (int l = 0; l <= 9; l++)
                            {
                                for (int m = 0; m <= 9; m++)
                                {
                                    for (int n = 0; n <= 9; n++)
                                    {


                                        if ((i + k + m) == (j + l + n))
                                        {
                                            Console.Write(newNumber + " ");
                                            newNumber++;
                                        }
                                        //else
                                        //    break;


                                    }
                                }
                            }
                        }
                    }

                }
            }
        }
    }
}
