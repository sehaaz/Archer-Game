using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archeer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Taking Ax input.
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Enter location of A:");

            Console.Write("Ax:");
            Console.ForegroundColor = ConsoleColor.White;
            int Ax = Convert.ToInt32(Console.ReadLine());

            // Checking validity.

            if (Ax > 10 || Ax < -10)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("You entered an invalid number.");
                Console.ReadLine(); // End
            }

            // Taking Ay input.
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("Ay:");
            Console.ForegroundColor = ConsoleColor.White;
            int Ay = Convert.ToInt32(Console.ReadLine());

            // Checking validity.

            if (Ay > 10 || Ay < -10)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("You entered an invalid number.");
                Console.ReadLine(); // End
            }

            // Getting Random() as rd.

            Random rd = new Random();

            // Random B and C values.

            int Bx = rd.Next(-10, 11);
            int By = rd.Next(-10, 11);

            int Cx = rd.Next(-10, 11);
            int Cy = rd.Next(-10, 11);

            // Taking random ASet value.

            int ASet = rd.Next(1, 4);

            // Taking BSet and CSet values for every ASet possibility.

            int BSet = 0, CSet = 0;

            if (ASet == 1)
            {
                BSet = rd.Next(2, 4);

                if (BSet == 2)
                {
                    CSet = 3;
                }
                else if (BSet == 3)
                {
                    CSet = 2;
                }
            }
            else if (ASet == 2)
            {
                BSet = (2 * rd.Next(1, 3)) - 1;
                if (BSet == 1)
                {
                    CSet = 3;
                }
                else if (BSet == 3)
                {
                    CSet = 1;
                }
            }
            else if (ASet == 3)
            {
                BSet = rd.Next(1, 3);

                if (BSet == 2)
                {
                    CSet = 1;
                }
                else if (BSet == 1)
                {
                    CSet = 2;
                }
            }

            // Taking random AHealth value.

            int AHealth, BHealth = 0, CHealth = 0;

            AHealth = 20 * (rd.Next(3, 6));

            // Taking BHealth and CHealth values for every AHealth possibility.

            if (AHealth == 60)
            {
                BHealth = 20 * (rd.Next(4, 6));

                if (BHealth == 80)
                {
                    CHealth = 100;
                }
                else if (BHealth == 100)
                {
                    CHealth = 80;
                }
            }
            else if (AHealth == 80)
            {
                BHealth = 20 + 40 * (rd.Next(1, 3));

                if (BHealth == 60)
                {
                    CHealth = 100;
                }
                else if (BHealth == 100)
                {
                    CHealth = 60;
                }
            }
            else if (AHealth == 100)
            {
                BHealth = 20 * rd.Next(3, 5);

                if (BHealth == 60)
                {
                    CHealth = 80;
                }
                else if (BHealth == 80)
                {
                    CHealth = 60;
                }
            }

            // Displaying values.
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("\n");
            Console.WriteLine("A: Set: {0} -- Health: {1,-3} -- Position: ({2},{3})", ASet, AHealth, Ax, Ay);
            Console.WriteLine("B: Set: {0} -- Health: {1,-3} -- Position: ({2},{3})", BSet, BHealth, Bx, By);
            Console.WriteLine("C: Set: {0} -- Health: {1,-3} -- Position: ({2},{3})", CSet, CHealth, Cx, Cy);
            Console.WriteLine("\n");

            // Displaying map.

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("   + - - - - - - - - - - ^ - - - - - - - - - - +");
            Console.WriteLine(" 10| . . . . . . . . . . | . . . . . . . . . . |");
            Console.WriteLine("  9| . . . . . . . . . . | . . . . . . . . . . |");
            Console.WriteLine("  8| . . . . . . . . . . | . . . . . . . . . . |");
            Console.WriteLine("  7| . . . . . . . . . . | . . . . . . . . . . |");
            Console.WriteLine("  6| . . . . . . . . . . | . . . . . . . . . . |");
            Console.WriteLine("  5| . . . . . . . . . . | . . . . . . . . . . |");
            Console.WriteLine("  4| . . . . . . . . . . | . . . . . . . . . . |");
            Console.WriteLine("  3| . . . . . . . . . . | . . . . . . . . . . |");
            Console.WriteLine("  2| . . . . . . . . . . | . . . . . . . . . . |");
            Console.WriteLine("  1| . . . . . . . . . . | . . . . . . . . . . |");
            Console.WriteLine("  0| - - - - - - - - - - + - - - - - - - - - - >");
            Console.WriteLine(" -1| . . . . . . . . . . | . . . . . . . . . . |");
            Console.WriteLine(" -2| . . . . . . . . . . | . . . . . . . . . . |");
            Console.WriteLine(" -3| . . . . . . . . . . | . . . . . . . . . . |");
            Console.WriteLine(" -4| . . . . . . . . . . | . . . . . . . . . . |");
            Console.WriteLine(" -5| . . . . . . . . . . | . . . . . . . . . . |");
            Console.WriteLine(" -6| . . . . . . . . . . | . . . . . . . . . . |");
            Console.WriteLine(" -7| . . . . . . . . . . | . . . . . . . . . . |");
            Console.WriteLine(" -8| . . . . . . . . . . | . . . . . . . . . . |");
            Console.WriteLine(" -9| . . . . . . . . . . | . . . . . . . . . . |");
            Console.WriteLine("-10| . . . . . . . . . . | . . . . . . . . . . |");
            Console.WriteLine("   + - - - - - - - - - - - - - - - - - - - - - +");
            Console.WriteLine("    10 9 8 7 6 5 4 3 2 1 0 1 2 3 4 5 6 7 8 9 10 ");
            Console.ResetColor();

            // Getting positions for SetCursorPosition().

            // APosition arrangement.

            int AyPosition = 0, AxPosition = 0;

            AxPosition = 3 + (11 + Ax) * 2;

            if (Ay < 0)
            {
                AyPosition = Math.Abs(Ay) + 21;
            }
            else if (Ay >= 0)
            {
                AyPosition = 21 - Ay;
            }

            Console.SetCursorPosition(AxPosition, AyPosition);
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("A");

            // BPosition arrangement.

            int ByPosition = 0, BxPosition = 0;

            BxPosition = 3 + (11 + Bx) * 2;

            if (By < 0)
            {
                ByPosition = Math.Abs(By) + 21;
            }
            else if (By >= 0)
            {
                ByPosition = 21 - By;
            }

            Console.SetCursorPosition(BxPosition, ByPosition);
            Console.Write("B");

            // CPosition arrangement.

            int CyPosition = 0, CxPosition = 0;

            CxPosition = 3 + (11 + Cx) * 2;

            if (Cy < 0)
            {
                CyPosition = Math.Abs(Cy) + 21;
            }
            else if (Cy >= 0)
            {
                CyPosition = 21 - Cy;
            }

            Console.SetCursorPosition(CxPosition, CyPosition);
            Console.Write("C");

            // Manhattan Distance

            int mdab, mdac, mdbc;  // "|x1 - x2| + |y1 - y2|." 

            mdab = Math.Abs(Ax - Bx) + Math.Abs(Ay - By);
            mdac = Math.Abs(Ax - Cx) + Math.Abs(Ay - Cy);
            mdbc = Math.Abs(Bx - Cx) + Math.Abs(By - Cy);

            // Hypotenuse

            double hab, hac, hbc, shortesth = 0;

            hab = Math.Sqrt(Math.Pow(Bx - Ax, 2) + Math.Pow(By - Ay, 2));
            hac = Math.Sqrt(Math.Pow(Cx - Ax, 2) + Math.Pow(Cy - Ay, 2));
            hbc = Math.Sqrt(Math.Pow(Bx - Cx, 2) + Math.Pow(By - Cy, 2));

            // Finding shortest Hypotenuse distance and Fighters

            string fighter1 = "", fighter2 = "", fighter3 = "", fighter4 = "", WinnerFighter = "";

            if (hab <= hac && hab <= hbc)
            {
                shortesth = hab;
                fighter1 = "A";
                fighter2 = "B";
                fighter4 = "C";
            }
            else if (hac <= hab && hac <= hbc)
            {
                shortesth = hac;
                fighter1 = "A";
                fighter2 = "C";
                fighter4 = "B";
            }
            else if (hbc <= hac && hbc <= hab)
            {
                shortesth = hbc;
                fighter1 = "B";
                fighter2 = "C";
                fighter4 = "A";
            }

            // Situations and Scores

            string ASituation = "", BSituation = "", CSituation = "";

            int AScore = 0, BScore = 0, CScore = 0, MaxScore = 0;

            Console.SetCursorPosition(0, 35);

            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("A - B Distance: " + hab.ToString("0.00"));
            Console.WriteLine("A - C Distance: " + hac.ToString("0.00"));
            Console.WriteLine("B - C Distance: " + hbc.ToString("0.00"));

            if (shortesth > 15)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nThe archers are too far from each other. There is no fight.");
                Console.ReadLine(); // End
            }

            Console.WriteLine("\nShortest Distance: " + shortesth.ToString("0.00"));

            // Round 1

            if (fighter1 == "A" && fighter2 == "B")
            {
                // A Loser B Winner
                if ((ASet == 1 && BSet == 2) || (ASet == 2 && BSet == 3) || (ASet == 3 && BSet == 1))
                {
                    ASituation = "Defeated";
                    BSituation = "Survivor";
                    CSituation = "Non-fighter";

                    AHealth = 0;
                    BHealth = BHealth - 25;
                    BScore = (10 * mdab) + (100 - BHealth);
                    fighter3 = "B";
                    shortesth = hbc;
                    MaxScore = BScore;
                }
                // B Loser A Winner
                if ((ASet == 2 && BSet == 1) || (ASet == 3 && BSet == 2) || (ASet == 1 && BSet == 3))
                {
                    ASituation = "Survivor";
                    BSituation = "Defeated";
                    CSituation = "Non-fighter";

                    BHealth = 0;
                    AHealth = AHealth - 25;
                    AScore = (10 * mdab) + (100 - AHealth);
                    fighter3 = "A";
                    shortesth = hac;
                    MaxScore = AScore;
                }
            }
            else if (fighter1 == "A" && fighter2 == "C")
            {
                // A Loser C Winner
                if ((ASet == 1 && CSet == 2) || (ASet == 2 && CSet == 3) || (ASet == 3 && CSet == 1))
                {
                    ASituation = "Defeated";
                    BSituation = "Non-fighter";
                    CSituation = "Survivor";

                    AHealth = 0;
                    CHealth = CHealth - 25;
                    CScore = (10 * mdac) + (100 - CHealth);
                    fighter3 = "C";
                    shortesth = hbc;
                    MaxScore = CScore;
                }
                // C Loser A Winner
                if ((ASet == 2 && CSet == 1) || (ASet == 3 && CSet == 2) || (ASet == 1 && CSet == 3))
                {
                    ASituation = "Survivor";
                    BSituation = "Non-fighter";
                    CSituation = "Defeated";

                    CHealth = 0;
                    AHealth = AHealth - 25;
                    AScore = (10 * mdac) + (100 - AHealth);
                    fighter3 = "A";
                    shortesth = hab;
                    MaxScore = AScore;
                }
            }
            else if (fighter1 == "B" && fighter2 == "C")
            {
                // B Loser C Winner
                if ((BSet == 1 && CSet == 2) || (BSet == 2 && CSet == 3) || (BSet == 3 && CSet == 1))
                {
                    ASituation = "Non-fighter";
                    BSituation = "Defeated";
                    CSituation = "Survivor";

                    BHealth = 0;
                    CHealth = CHealth - 25;
                    CScore = (10 * mdbc) + (100 - CHealth);
                    fighter3 = "C";
                    shortesth = hac;
                    MaxScore = CScore;
                }
                // C Loser B Winner
                if ((BSet == 2 && CSet == 1) || (BSet == 3 && CSet == 2) || (BSet == 1 && CSet == 3))
                {
                    ASituation = "Non-fighter";
                    BSituation = "Survivor";
                    CSituation = "Defeated";

                    CHealth = 0;
                    BHealth = BHealth - 25;
                    BScore = (10 * mdbc) + (100 - BHealth);
                    fighter3 = "B";
                    shortesth = hab;
                    MaxScore = BScore;
                }
            }
            
            Console.WriteLine("\nROUND 1 -- Fight: " + fighter1 + " - " + fighter2);
            Console.WriteLine("A: {0,-11}   Health: {1,-3}   Score: {2,-3}", ASituation, AHealth, AScore);
            Console.WriteLine("B: {0,-11}   Health: {1,-3}   Score: {2,-3}", BSituation, BHealth, BScore);
            Console.WriteLine("C: {0,-11}   Health: {1,-3}   Score: {2,-3}", CSituation, CHealth, CScore);

            Console.WriteLine("\nLast Distance: " + shortesth.ToString("0.00"));

            if (shortesth >15)
            {
                Console.WriteLine("\nROUND 2 -- Fight: " + fighter3 + " - " + fighter4);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nToo distant, no attack.");

                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\n"+ fighter3 + " has the maximum score. ("+ MaxScore + ")");
                Console.ReadLine();
            }

            // Round 2

            if(shortesth == hab)
            {
                // A Loser B Winner
                if ((ASet == 1 && BSet == 2) || (ASet == 2 && BSet == 3) || (ASet == 3 && BSet == 1))
                {
                    ASituation = "Defeated";
                    BSituation = "Survivor";

                    AHealth = 0;
                    BHealth = BHealth - 25;
                    BScore = (10 * mdab) + (100 - BHealth);
                }
                // B Loser A Winner
                if ((ASet == 2 && BSet == 1) || (ASet == 3 && BSet == 2) || (ASet == 1 && BSet == 3))
                {
                    ASituation = "Survivor";
                    BSituation = "Defeated";

                    BHealth = 0;
                    AHealth = AHealth - 25;
                    AScore = (10 * mdab) + (100 - AHealth);
                }
            }
            else if(shortesth == hac)
            {
                // A Loser C Winner
                if ((ASet == 1 && CSet == 2) || (ASet == 2 && CSet == 3) || (ASet == 3 && CSet == 1))
                {
                    ASituation = "Defeated";
                    CSituation = "Survivor";

                    AHealth = 0;
                    CHealth = CHealth - 25;
                    CScore = (10 * mdac) + (100 - CHealth);
                }
                // C Loser A Winner
                if ((ASet == 2 && CSet == 1) || (ASet == 3 && CSet == 2) || (ASet == 1 && CSet == 3))
                {
                    ASituation = "Survivor";
                    CSituation = "Defeated";

                    CHealth = 0;
                    AHealth = AHealth - 25;
                    AScore = (10 * mdac) + (100 - AHealth);
                }
            }
            else if (shortesth == hbc)
            {
                // B Loser C Winner
                if ((BSet == 1 && CSet == 2) || (BSet == 2 && CSet == 3) || (BSet == 3 && CSet == 1))
                {
                    BSituation = "Defeated";
                    CSituation = "Survivor";

                    BHealth = 0;
                    CHealth = CHealth - 25;
                    CScore = (10 * mdbc) + (100 - CHealth);
                }
                // C Loser B Winner
                if ((BSet == 2 && CSet == 1) || (BSet == 3 && CSet == 2) || (BSet == 1 && CSet == 3))
                {
                    BSituation = "Survivor";
                    CSituation = "Defeated";

                    CHealth = 0;
                    BHealth = BHealth - 25;
                    BScore = (10 * mdbc) + (100 - BHealth);
                }
            }

            // Winner detection

            if (AScore >= BScore && AScore >= CScore)
            {
                WinnerFighter = "A";
                MaxScore = AScore;
            }
            else if (BScore >= AScore && BScore >= CScore)
            {
                WinnerFighter = "B";
                MaxScore = BScore;
            }
            else if(CScore >= AScore && CScore >= BScore)
            {
                WinnerFighter = "C";
                MaxScore = CScore;
            }

            Console.WriteLine("\nROUND 2 -- Fight: " + fighter3 + " - " + fighter4);
            Console.WriteLine("A: {0,-11}   Health: {1,-3}   Score: {2,-3}" , ASituation, AHealth, AScore);
            Console.WriteLine("B: {0,-11}   Health: {1,-3}   Score: {2,-3}" , BSituation, BHealth, BScore);
            Console.WriteLine("C: {0,-11}   Health: {1,-3}   Score: {2,-3}" , CSituation, CHealth, CScore);

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n" + WinnerFighter + " has the maximum score. (" + MaxScore + ")");

            Console.ReadLine();
        }
    }
}