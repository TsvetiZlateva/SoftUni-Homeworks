using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnTimeForTheExam
{
    class Program
    {
        static void Main(string[] args)
        {
            int hExam = int.Parse(Console.ReadLine());
            int mExam = int.Parse(Console.ReadLine());
            int hArrival = int.Parse(Console.ReadLine());
            int mArrival = int.Parse(Console.ReadLine());

            int mSumExam = hExam * 60 + mExam;
            int mSumArrival = hArrival * 60 + mArrival;

            if (mSumArrival > mSumExam)
            {
                Console.WriteLine("Late");

                if (mSumArrival - mSumExam < 60)
                {
                    Console.WriteLine($"{mSumArrival - mSumExam} minutes after the start");
                }
                else
                {
                    Console.WriteLine($"{(mSumArrival - mSumExam) / 60}:{(mSumArrival - mSumExam) % 60:D2} hours after the start");
                }
            }
            else
            {
                if (mSumArrival <= mSumExam || mSumArrival >= mSumExam - 30)
                {
                    Console.WriteLine("On time");
                }
                else
                {
                    Console.WriteLine("Early");

                    if (mSumExam - mSumArrival != 0)
                    {
                        if (mSumExam - mSumArrival < 60)
                        {
                            Console.WriteLine($"{mSumExam - mSumArrival} minutes before the start");
                        }
                        else
                        {
                            Console.WriteLine($"{(mSumExam - mSumArrival) / 60}:{(mSumExam - mSumArrival) % 60:D2} hours before the start");
                        }
                    }
                }
            }
        }
    }
}
