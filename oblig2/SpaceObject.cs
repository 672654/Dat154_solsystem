using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace SpaceSim {

    public class SpaceObject
    {
        public string Name { get; protected set; }
        public int OrbitalRadius { get; protected set; }
        public int OrbitalPeriod {  get; protected set; }
        public int ObjectRadius { get; protected set; }
        public int RotationalPeriod {  get; protected set; }
        public string ObjectColor { get; protected set; }


        public SpaceObject(string name, int orbitalRadius, int orbitalPeriod, int objectRadius, int rotationalPerioid, string color)
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
        public int GetOrbitalPeriod()
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

            double angle = time * (OrbitalPeriod / 360); // Calculate angle in degrees
            double radians = angle * (Math.PI/180); // Convert to radians

            int x = (int)(GetOrbitalRadius() * Math.Cos(radians));
            //Console.WriteLine(angle);
            int y = (int)(GetOrbitalRadius() * Math.Sin(radians));
            //Console.WriteLine(y);
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
        
        public Planet(string name, int orbitalRadius, int orbitalPeriod, int objectRadius, int rotationalPerioid, string color) : base(name, orbitalRadius, orbitalPeriod, objectRadius, rotationalPerioid, color) {
           
        
        }
        public override void Draw() {
            Console.Write("Planet : ");
            base.Draw();
        }
           
    }

    public class Moon : SpaceObject
    {
        public SpaceObject ParentPlanet {  get; private set; }
        public Moon(string name, int orbitalRadius, int orbitalPeriod, int objectRadius, int rotationalPerioid, string color, SpaceObject parent) 
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

            double mAngle = time * (OrbitalPeriod / 360); // Calculate angle in degrees
            double mRadians = mAngle * (Math.PI / 180); // Convert to radians

            double pAngle = time * (ParentPlanet.GetOrbitalPeriod() / 360); // Calculate angle in degrees
            double pRadians = pAngle * (Math.PI / 180); // Convert to radians

            int mx = (int)(GetOrbitalRadius() * Math.Cos(mRadians));
            int my = (int)(GetOrbitalRadius() * Math.Sin(mRadians));

            int px = (int)(ParentPlanet.GetOrbitalRadius() * Math.Cos(pRadians));
            int py = (int)(ParentPlanet.GetOrbitalRadius() * Math.Sin(pRadians));
            
            return (mx + px, my + py);
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