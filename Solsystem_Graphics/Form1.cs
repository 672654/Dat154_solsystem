using SpaceSim;  // Ensure we can use SpaceObject classes
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using Timer = System.Windows.Forms.Timer;

namespace Solsystem_Graphics
{
    public partial class Form1 : Form
    {
        private Timer timer;
        private int time = 0;
        private Dictionary<string, PictureBox> objectPictures; // Map names to PictureBoxes
        private List<SpaceObject> solarSystem;

        public Form1()
        {
            InitializeComponent();
            InitializeSolarSystem();
            InitializeTimer();
        }

        private void InitializeSolarSystem()
        {
            // Create an empty list first
            solarSystem = new List<SpaceObject>();

            // Add the Sun and planets first
            solarSystem.Add(new Star("sun", 0, 0, 100, 100, "Yellow"));
            solarSystem.Add(new Planet("earth", 400, 365, 100, 200, "blue"));

            // Now find Earth before adding the Moon
            SpaceObject earth = solarSystem.Find(p => p.Name == "earth");

            // Add the Moon with a valid reference to Earth
            solarSystem.Add(new Moon("the moon", 150, 200, 30, 200, "white", earth));

            // Dictionary to map PictureBoxes to celestial objects
            objectPictures = new Dictionary<string, PictureBox>
    {
        { "sun", Sun },   // Assuming "Sun" is a PictureBox in your Form
        { "earth", Earth },  // Assuming "Earth" is a PictureBox in your Form
        { "the moon", The_Moon }
    };

            // Create a PictureBox for the moon dynamically
            //PictureBox The_Moon = new PictureBox
            //{
            //    Name = "Moon",
            //    Size = new Size(30, 30),
            //    BackColor = Color.White,
            //    SizeMode = PictureBoxSizeMode.StretchImage
            //};
            //Controls.Add(The_Moon);
            //objectPictures.Add("the moon", The_Moon);
        }


        private void InitializeTimer()
        {
            timer = new Timer();
            timer.Interval = 50;  // Update every 50 milliseconds
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            time += 1; // Increment time step
            UpdateObjectPositions();
        }

        private void UpdateObjectPositions()
        {
            foreach (var obj in solarSystem)
            {
                if (objectPictures.TryGetValue(obj.Name, out PictureBox pictureBox))
                {
                    var (x, y) = obj.CalculatePositions(time);

                    // Offset so (0,0) is in the center of the form
                    int centerX = ClientSize.Width / 2;
                    int centerY = ClientSize.Height / 2;

                    pictureBox.Location = new Point(centerX + x - (pictureBox.Width/2), centerY + y - (pictureBox.Height / 2));
                }
            }
        }
    }
}
