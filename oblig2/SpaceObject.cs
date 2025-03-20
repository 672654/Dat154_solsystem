using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace SpaceSim {

    public class SpaceObject
    {
        public string Name { get; protected set; }
        public int OrbitalRadius { get; protected set; }
        public double OrbitalPeriod {  get; protected set; }
        public int ObjectRadius { get; protected set; }
        public int RotationalPeriod {  get; protected set; }
        public string ObjectColor { get; protected set; }


        public SpaceObject(string name, int orbitalRadius, double orbitalPeriod, int objectRadius, int rotationalPerioid, string color)
        {
            Name = name;
            OrbitalRadius = orbitalRadius;
            OrbitalPeriod = orbitalPeriod;
            ObjectRadius = objectRadius;
            RotationalPeriod = rotationalPerioid;
            ObjectColor = color;
        }

        public virtual void Draw()
        {
            Console.WriteLine(Name);
        }

        public void SetOrbitalRadius(int r)
        {
            OrbitalRadius = r;
        }
        public int GetOrbitalRadius()
        {
            return OrbitalRadius;
        }
        public void SetOrbitalPeriod(int period)
        {
            OrbitalPeriod = period;
        }
        public double GetOrbitalPeriod()
        {
            return OrbitalPeriod;
        }
        public void SetObjectRadius(int radius)
        {
            ObjectRadius = radius;
        }
        public int GetObjectRadius()
        {
            return ObjectRadius;
        }
        public void SetObjectColor(string color)
        {
            ObjectColor = color;
        }
        public string GetObjectColor()
        {
            return ObjectColor;
        }

        public virtual (int x, int y) CalculatePositions(int time)
        {

            double angle = time * (360 / OrbitalPeriod); // Calculate angle in degrees
            double radians = angle * (Math.PI/180); // Convert to radians

            //double ScalingFactor = 20000;
            double Normalization = Math.Sqrt(Math.Pow(900,2) + Math.Pow(100,2));
            //if (Name == "pluto"){
            //    Normalization = 5000;
            //}

            //double divisor = ((OrbitalRadius) / Normalization);
            //divisor = divisor / 10;
            //if (divisor > 1200)
            //{
            //    divisor = 1000;
            //}

            int x = (int)(((OrbitalRadius / Normalization) * Math.Cos(radians)));
            int y = (int)(((OrbitalRadius / Normalization) * Math.Sin(radians)));
            //x = (int)(x / Normalization);
            //y = (int)(y / Normalization);

            return (x, y);
        }

        public void displayInfo(int time)
        {
            Console.WriteLine(this.Name);
        }
                
    }

    public class Star : SpaceObject
    {
        public Star(string name, int orbitalRadius, int orbitalPeriod, int objectRadius, int rotationalPerioid, string color) : base(name, orbitalRadius, orbitalPeriod, objectRadius, rotationalPerioid, color) {
            
        }
        public override void Draw()
        {
            Console.Write("Star : " );
            base.Draw();
        }
    }

    public class Planet : SpaceObject
    {
        
        public Planet(string name, int orbitalRadius, double orbitalPeriod, int objectRadius, int rotationalPerioid, string color) : base(name, orbitalRadius, orbitalPeriod, objectRadius, rotationalPerioid, color) {
           
        
        }
        public override void Draw() {
            Console.Write("Planet : ");
            base.Draw();
        }
           
    }

    public class Moon : SpaceObject
    {
        public SpaceObject ParentPlanet {  get; private set; }
        public Moon(string name, int orbitalRadius, double orbitalPeriod, int objectRadius, int rotationalPerioid, string color, SpaceObject parent) 
            : base(name, orbitalRadius, orbitalPeriod, objectRadius, rotationalPerioid, color) 
        { 
            ParentPlanet = parent;
        }
        public override void Draw()
        {
            Console.Write("Moon : ");
            base.Draw();
        }

        public override (int x, int y) CalculatePositions(int time)
        {
            if (ParentPlanet == null)
            {
                throw new NullReferenceException("Parent planet is not assigned for the moon.");
            }

            // Get Earth's (parent's) position
            var (px, py) = ParentPlanet.CalculatePositions(time);

            // Calculate the Moon's own position in orbit around Earth
            double mAngle = time * (360 / OrbitalPeriod); // Degrees per time unit
            double mRadians = mAngle * (Math.PI / 180.0);  // Convert to radians

            //double divisor = (OrbitalRadius / 100);
            //double Normalization = Math.Sqrt(Math.Pow(300, 2) - Math.Pow(100, 2));
            double Normalization = 10;

            int mx = (int)((OrbitalRadius/Normalization) * Math.Cos(mRadians));
            int my = (int)((OrbitalRadius/Normalization) * Math.Sin(mRadians));

            // Return the Moon's position relative to Earth's position
            return (px + mx, py + my);
        }

    }

    public class Comet : SpaceObject
    {
        public Comet(string name, int orbitalRadius, int orbitalPeriod, int objectRadius, int rotationalPerioid, string color) : base(name, orbitalRadius, orbitalPeriod, objectRadius, rotationalPerioid, color) { }

        public override void Draw()
        {
            Console.Write("Comet : ");
            base.Draw();
        }
    }


    public class Asteroid : SpaceObject
    {
        public Asteroid(string name, int orbitalRadius, int orbitalPeriod, int objectRadius, int rotationalPerioid, string color) : base(name, orbitalRadius, orbitalPeriod, objectRadius, rotationalPerioid, color) { }

        public override void Draw()
        {
            Console.Write("Asteroid : ");
            base.Draw();
        }
    }

    public class AsteroidBelt : SpaceObject
    {
        public AsteroidBelt(string name, int orbitalRadius, int orbitalPeriod, int objectRadius, int rotationalPerioid, int amount, string color) : base(name, orbitalRadius, orbitalPeriod, objectRadius, rotationalPerioid, color) { }

        public override void Draw()
        {
            Console.Write("Asteroid Belt : ");
            base.Draw();
        }
    }

    public class DwarfPlanet : SpaceObject
    {
        public DwarfPlanet(string name, int orbitalRadius, int orbitalPeriod, int objectRadius, int rotationalPerioid, string color) : base(name, orbitalRadius, orbitalPeriod, objectRadius, rotationalPerioid, color) { }

        public override void Draw()
        {
            Console.Write("Dwarf Planet : ");
            base.Draw();
        }
    }
}