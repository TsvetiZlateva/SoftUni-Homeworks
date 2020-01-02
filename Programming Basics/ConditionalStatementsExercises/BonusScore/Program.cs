using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonusScore
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            if (num <= 100)
            {
                double bonus = 5;
                double total = num + bonus;

                if (num % 2 == 0)
                {
                    double evenBonus = 1;
                    double allBonus = bonus + evenBonus;
                    double sum = total + evenBonus;

                    Console.WriteLine(allBonus);
                    Console.WriteLine(sum);
                }
                else if (num % 10 == 5)
                {
                    double fiveBonus = 2;
                    double allBonus = bonus + fiveBonus;
                    double sum = total + fiveBonus;

                    Console.WriteLine(allBonus);
                    Console.WriteLine(sum);
                }
                else
                {
                    Console.WriteLine(bonus);
                    Console.WriteLine(total);
                }
            }
            else if (num > 100 && num <= 1000)
            {
             
                    double bonus = num * 0.20;
                    double total = num + bonus;

                    if (num % 2 == 0)
                    {
                        double evenBonus = 1;
                        double allBonus = bonus + evenBonus;
                        double sum = total + evenBonus;

                        Console.WriteLine(allBonus);
                        Console.WriteLine(sum);
                    }
                    else if (num % 10 == 5)
                    {
                        double fiveBonus = 2;
                        double allBonus = bonus + fiveBonus;
                        double sum = total + fiveBonus;

                        Console.WriteLine(allBonus);
                        Console.WriteLine(sum);
                    }
                else
                {
                    Console.WriteLine(bonus);
                    Console.WriteLine(total);
                }

            }
            else if (num > 1000)
            {
                double bonus = num * 0.10;
                double total = num + bonus;

                if (num % 2 == 0)
                {
                    double evenBonus = 1;
                    double allBonus = bonus + evenBonus;
                    double sum = total + evenBonus;

                    Console.WriteLine(allBonus);
                    Console.WriteLine(sum);
                }
                else if (num % 10 == 5)
                {
                    double fiveBonus = 2;
                    double allBonus = bonus + fiveBonus;
                    double sum = total + fiveBonus;

                    Console.WriteLine(allBonus);
                    Console.WriteLine(sum);
                }
                else
                {
                    Console.WriteLine(bonus);
                    Console.WriteLine(total);
                }
            }
            }
        }
    }



