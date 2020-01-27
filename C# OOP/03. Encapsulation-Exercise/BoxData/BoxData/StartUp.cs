using System;

namespace BoxData
{
    class StartUp
    {
        static void Main(string[] args)
        {
            try
            {
                double length = 0;
                double width = 0;
                double height = 0;

                for (int i = 0; i < 3; i++)
                {
                    double number = double.Parse(Console.ReadLine());

                    switch (i)
                    {
                        case 0:
                            length = number;
                            break;
                        case 1:
                            width = number;
                            break;
                        case 2:
                            height = number;
                            break;
                    }
                }

                Box box = new Box(length, width, height);

                Console.WriteLine($"Surface Area - {box.Area():f2}");
                Console.WriteLine($"Lateral Surface Area - {box.LateralArea():f2}");
                Console.WriteLine($"Volume - {box.Volume():f2}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
