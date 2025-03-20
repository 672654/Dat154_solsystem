using SpaceSim;  // Ensure we can use SpaceObject classes
using ConsoleApp;
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
            InitializeSystem();
            InitializeTimer();
            this.KeyDown += new KeyEventHandler(FormKeyDown);
            this.KeyPreview = true;
        }

        private void InitializeSystem()
        {
            // Create an empty list first

            solarSystem = Astronomy.InitializeSolarSystem();

            
            objectPictures = new Dictionary<string, PictureBox>
    {
        { "sun", Sun },
        { "mercury", Mercury },
        { "venus", Venus },
        { "earth", Earth },
        { "the moon", The_Moon },
        { "mars", Mars },
        { "jupiter", Jupiter },
        { "saturn", Saturn },
        { "uranus", Uranus },
        { "neptune", Neptune },
        { "pluto", Pluto }
    };
            foreach (var obj in objectPictures)
            {
                PictureBox planetPicture = obj.Value;
                SpaceObject planet = solarSystem.Find(s => s.Name == obj.Key);
                planetPicture.Width = planet.GetObjectRadius();
                planetPicture.Height = planet.GetObjectRadius();
            }
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
            timer.Tick += Do_Tick;
            timer.Start();
        }

        //private void ChangeTimer(int interval)
        //{
        //    timer.Interval = interval;
        //}

        private void FormKeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    if (timer.Interval <= 10)
                    {
                        // do nothing
                    }
                    else
                    {
                        timer.Interval -= 10;
                    }
                    break;
                case Keys.Right:
                    timer.Interval += 10;
                    break;
                default:
                    break;
            }
        }

        private void Do_Tick(object sender, EventArgs e)
        {
            time += 1; // Increment time step
            Days.Text = time.ToString() + " Days";
            TickInterval.Text = timer.Interval.ToString() + "ms";
            UpdateObjectPositions();
        }

        private void UpdateObjectPositions()
        {
            foreach (var obj in solarSystem)
            {
                if (objectPictures.TryGetValue(obj.Name, out PictureBox pictureBox))
                {
                    //pictureBox.Size = System.Drawing.Size();
                    
                    SpaceObject focusBody = solarSystem.Find(s => s.Name == FocusObject.Text);
                    var scale = 1;

                    if (focusBody == null)
                    {
                        focusBody = solarSystem.Find(s => s.Name == "sun");
                        pictureBox.Width = obj.ObjectRadius;
                        pictureBox.Height = obj.ObjectRadius;
                        scale = 1;
                        //pictureBox.Size = new Size(obj.ObjectRadius, obj.ObjectRadius);
                    }
                    else if (focusBody.Name == "sun")
                    {
                        scale = 1;
                        pictureBox.Width = obj.ObjectRadius;
                        pictureBox.Height = obj.ObjectRadius;
                        //pictureBox.Size = new Size(obj.ObjectRadius * 10, obj.ObjectRadius * 10);
                    } else
                    {
                        pictureBox.Width = obj.ObjectRadius;
                        pictureBox.Height = obj.ObjectRadius;
                        scale = 10;
                    }

                        //SpaceObject planet = solarSystem.Find(s => s.Name == FocusObject.Text);
                    var (offsetX, offsetY) = focusBody.CalculatePositions(time);

                    var (x, y) = obj.CalculatePositions(time);

                    // Offset so (0,0) is in the center of the form
                    int centerX = ClientSize.Width / 2 - (offsetX * scale);
                    int centerY = ClientSize.Height / 2 - (offsetY * scale);

                    pictureBox.Location = new Point(centerX + (x * scale) - (pictureBox.Width/2), centerY + (y * scale) - (pictureBox.Height / 2));
                }
            }
        }
    }
}
