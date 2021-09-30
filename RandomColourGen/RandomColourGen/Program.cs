using System;
using System.Collections.Generic;

namespace RandomColourGen
{
    class Program
    {
        static void Main(string[] args)
        {
            #region VARIABLES BABY!!
            Random rnd = new Random();
            //Make an extra max*Colour* and set it to 0
            //For example:
            //int maxPurple = 0;
            int maxDG = 0;
            int maxG = 0;
            int maxLG = 0;
            int maxGB = 0;
            int maxP = 0;
            int x = 0;
            #endregion

            #region WOOO! MAKE THAT LIST, BABY!!!
            //If you want to add another colour just put it in here ↓                                   for example: ↓
            List<string> Colours = new List<string> { "Dark Gray", "Gray", "Light Gray", "Green/ Blue", "Pink" /*, "Purple"*/ };
            #endregion

            #region Loop that bitch
            //Change this number ↓ to what the max number of your pattern is
            for (int i = 1; i < 36; i++)
            {
                #region Make a random number
                //put in the number of colours you have so if you have 6 colours:
                //if (Colours.Count == 6)
                //{
                //    x = rnd.Next(0, 6);
                //} and an else infront of following if
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
                #endregion

                #region Check if colour is used
                //Add in the max*colour* variable you made at the top
                //For example:
                //if (Colours[x] == "Purple")
                //{
                //    maxPurple++;
                //}
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
                #endregion

                #region Write that shit down
                //You don't need to edit anything here
                Console.WriteLine($"Position number {i} = {Colours[x]}");
                #endregion

                #region Check if colour is used at it's max
                //Add code to check if your extra colours hit their maximum
                //For example:
                //if (maxPurple == 7)
                //{
                //    Colours.Remove("Purple");
                //}
                //Devide the max pattern number by the amount of colours you have
                if (maxDG == 7/*change this number to the number above ↑ */)
                {   //NOTE: you can also just put it to random numbers just be sure that the numbers of all the characters adds up to your max pattern colour
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
                #endregion
            }
            #endregion
        }
    }
}
