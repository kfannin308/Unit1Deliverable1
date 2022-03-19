using System;

namespace Unit1Deliverable
{
    class Program
    {
        public static void Main()
        {
            bool cont;
            do
            {
                Console.WriteLine("How many people are we making PB&J sandwiches for?");

                int numPeople = int.Parse(Console.ReadLine());
                double slicesNeeded = CalcSlices(numPeople);
                double pbTbsNeeded = CalcPbTbs(numPeople);
                double jellyTsNeeded = CalcJellyTs(numPeople);
                double loavesNeeded = CalcLoavesNeeded(slicesNeeded);
                double pbJarsNeeded = CalcPbJarsNeeded(pbTbsNeeded);
                double jellyJarsNeeded = CalcJellyJarsNeeded(jellyTsNeeded);

                Console.WriteLine("You need: \r\n" +
                    "    " + slicesNeeded + " slices of bread \r\n" +
                    "    " + pbTbsNeeded + " tablespoons of peanut butter \r\n" +
                    "    " + jellyTsNeeded + " teaspoons of jelly \r\n \r\n which is... \r\n\r\n" +
                    "    " + loavesNeeded + " loaves of bread \r\n" +
                    "    " + pbJarsNeeded + " jars of peanut butter \r\n" +
                    "    " + jellyJarsNeeded + " jars of jelly \r\n \r\n" +
                    "Would you like to restart? Enter yes or y to continue, or enter any other key to exit.");
                string contString = Console.ReadLine();
                if (contString == "yes" || contString == "y")
                { cont = true; }
                else
                {
                    cont = false;
                }

            } while (cont == true);
            Console.WriteLine("Goodbye!");
        }

        public static int CalcSlices(int people)
        {
            int slices = people * 2;
            return slices;
        }
        public static int CalcPbTbs(int people)
        {
            int pbTbs = people * 2;
            return pbTbs;
        }
        public static int CalcJellyTs(int people)
        {
            int jellyTs = people * 4;
            return jellyTs;
        }
        public static double CalcLoavesNeeded(double totalSlicesNeeded)
        {
            int slicesPerLoaf = 28;
            double totalLoavesNeeded = totalSlicesNeeded / slicesPerLoaf;
            double RoundedUpLoaves = Math.Ceiling(totalLoavesNeeded);
            return RoundedUpLoaves;
        }
        public static double CalcPbJarsNeeded(double totalPbTbsNeeded)
        {
            int tbsPerJar = 32;
            double totalPbJarsNeeded = totalPbTbsNeeded / tbsPerJar;
            double RoundedUpPbJars = Math.Ceiling(totalPbJarsNeeded);
            return RoundedUpPbJars;
        }
        public static double CalcJellyJarsNeeded(double totalJellyTsNeeded)
        {
            int tsPerJar = 48;
            double totalJellyJarsNeeded = totalJellyTsNeeded / tsPerJar;
            double RoundedUpJellyJars = Math.Ceiling(totalJellyJarsNeeded);
            return RoundedUpJellyJars;
        }
    }
}