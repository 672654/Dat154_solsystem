using System;
using System.Collections.Generic;
using System.Numerics;
using SpaceSim;
//using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace ConsoleApp
{
    public class Astronomy
    {

        public static void Main()
        {
            //InitializeSolarSystem();

            //while (true)
            //{
            //    Console.Write("Enter time (number of days since time = 0: ");
            //    int time = Convert.ToInt32(Console.ReadLine());


            //    Console.Write("Enter name of Planet or write sun for the sun: ");
            //    string spaceObjectString = Console.ReadLine().Trim();

            //    spaceObjectString = string.IsNullOrWhiteSpace(spaceObjectString) ? "Sun" : spaceObjectString;

            //    SpaceObject spaceObject = solarSystem.Find(s  => s.Name == spaceObjectString);

            //    if (solarSystem.Contains(spaceObject))
            //    {
            //        spaceObject.displayInfo(time);
            //        Console.WriteLine("info.....");
            //        Console.WriteLine(spaceObject.CalculatePositions(time));
            //    } 
            //    else
            //    {
            //        Console.WriteLine("That celestial body does not exist. Please try again");
            //    }
            //}
        }

        public static List<SpaceObject> InitializeSolarSystem()
        {
            List<SpaceObject> solarSystem = new List<SpaceObject>();

            //solarSystem.Add(new Planet(name, orbitalRadius, orbitalPeriod, objectRadius, rotationalperiod, color));
            solarSystem.Add(new Star("sun", 0, 0, 100, 100, "Yellow"));
            solarSystem.Add(new Planet("mercury", 57910, 87.97, 5, 200, "silver"));
            solarSystem.Add(new Planet("venus", 108200, 224.70, 12, 200, "orange"));
            solarSystem.Add(new Planet("earth", 149600, 365.26, 40, 200, "blue"));
            solarSystem.Add(new Moon("the moon", 384, 27.32, 15, 200, "white", solarSystem.Find(p => p.Name == "earth")));
            solarSystem.Add(new Planet("mars", 227940, 686.98, 30, 200, "orange"));
            solarSystem.Add(new Planet("jupiter", 778330/2, 4332.71, 100, 200, "grey"));
            solarSystem.Add(new Planet("saturn", 1429400/2, 10759.5, 100, 200, "grey"));
            solarSystem.Add(new Planet("uranus", 2870990/2, 30685.0, 100, 200, "blue"));
            solarSystem.Add(new Planet("neptune", 4504300, 60190.0, 100, 200, "blue"));
            solarSystem.Add(new Planet("pluto", 5913520, 90550.00, 10, 200, "grey"));
            solarSystem.Add(new Comet("C01", 100, 2000, 100, 2000, "black"));
            solarSystem.Add(new Asteroid("A01", 200, 1000, 100, 1000, "black"));

            return solarSystem;
        }
    }
}