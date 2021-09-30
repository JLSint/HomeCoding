using System;
using System.Collections.Generic;

namespace RandomColourGen
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int maxDG = 0;
            int maxG = 0;
            int maxLG = 0;
            int maxGB = 0;
            int maxP = 0;
            int x = 0;

            List<string> Colours = new List<string> { "Dark Gray", "Gray", "Light Gray", "Green/ Blue", "Pink" };

            for (int i = 1; i < 36; i++)
            {

                if (Colours.Count == 5)
                {
                    x = rnd.Next(0, 5);
                } else if (Colours.Count == 4)
                {
                    x = rnd.Next(0, 4);
                } else if (Colours.Count == 3)
                {
                    x = rnd.Next(0, 3);
                } else if (Colours.Count == 2)
                {
                    x = rnd.Next(0, 2);
                } else if (Colours.Count == 1)
                {
                    x = rnd.Next(0, 1);
                }

                if (Colours[x] == "Dark Gray")
                {
                    maxDG++;
                } if (Colours[x] == "Gray")
                {
                    maxG++;
                }
                if (Colours[x] == "Light Gray")
                {
                    maxLG++;
                }
                if (Colours[x] == "Green/ Blue")
                {
                    maxGB++;
                }
                if (Colours[x] == "Pink")
                {
                    maxP++;
                }

                    Console.WriteLine($"Position number {i} = {Colours[x]} {maxDG} {maxG} {maxLG} {maxGB} {maxP}");
                
                if (maxDG == 7)
                {
                    Colours.Remove("Dark Gray");
                } if(maxG == 7)
                {
                    Colours.Remove("Gray");
                } if(maxLG == 7)
                {
                    Colours.Remove("Light Gray");
                } if(maxGB == 7)
                {
                    Colours.Remove("Green/ Blue");
                } if(maxP == 7)
                {
                    Colours.Remove("Pink");
                }
                
            }
        }
    }
}
