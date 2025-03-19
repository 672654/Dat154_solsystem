using System;
using System.Collections.Generic;
using System.Numerics;
using SpaceSim;


class Astronomy
{

    public static void Main()
    {
        List<SpaceObject> solarSystem = new List<SpaceObject>();

        solarSystem.Add(new Star("sun", 0, 0, 100, 100, "Yellow"));
        solarSystem.Add(new Planet("mars", 300, 686, 100, 200, "orange"));
        solarSystem.Add(new Planet("jupiter", 350, 4332, 100, 200, "grey"));
        solarSystem.Add(new Planet("earth", 400, 365, 100, 200, "blue"));
        solarSystem.Add(new Moon("the moon", 50, 200, 30, 200, "white", solarSystem.Find(p => p.Name == "earth")));
        solarSystem.Add(new Comet("C01", 100, 2000, 100, 2000, "black"));
        solarSystem.Add(new Asteroid("A01", 200, 1000, 100, 1000, "black"));        
        
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
}
