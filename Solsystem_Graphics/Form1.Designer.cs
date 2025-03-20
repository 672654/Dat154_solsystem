namespace Solsystem_Graphics
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Earth = new PictureBox();
            Sun = new PictureBox();
            The_Moon = new PictureBox();
            Mercury = new PictureBox();
            Pluto = new PictureBox();
            Days = new Label();
            TickInterval = new Label();
            FocusObject = new ComboBox();
            Venus = new PictureBox();
            Mars = new PictureBox();
            Jupiter = new PictureBox();
            Saturn = new PictureBox();
            Uranus = new PictureBox();
            Neptune = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)Earth).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Sun).BeginInit();
            ((System.ComponentModel.ISupportInitialize)The_Moon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Mercury).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Pluto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Venus).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Mars).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Jupiter).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Saturn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Uranus).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Neptune).BeginInit();
            SuspendLayout();
            // 
            // Earth
            // 
            Earth.BackColor = SystemColors.Control;
            Earth.Cursor = Cursors.Hand;
            Earth.Image = Properties.Resources.Blue_marble_700x525;
            Earth.ImageLocation = "";
            Earth.Location = new Point(694, 187);
            Earth.MaximumSize = new Size(40, 40);
            Earth.Name = "Earth";
            Earth.Size = new Size(37, 25);
            Earth.SizeMode = PictureBoxSizeMode.StretchImage;
            Earth.TabIndex = 0;
            Earth.TabStop = false;
            // 
            // Sun
            // 
            Sun.Image = Properties.Resources.The_Sun_by_the_Atmospheric_Imaging_Assembly_of_NASA_s_Solar_Dynamics_Observatory___20100819;
            Sun.Location = new Point(342, 187);
            Sun.MaximumSize = new Size(200, 200);
            Sun.Name = "Sun";
            Sun.Size = new Size(50, 50);
            Sun.SizeMode = PictureBoxSizeMode.StretchImage;
            Sun.TabIndex = 1;
            Sun.TabStop = false;
            // 
            // The_Moon
            // 
            The_Moon.Image = Properties.Resources.FullMoon2010;
            The_Moon.Location = new Point(883, 187);
            The_Moon.Name = "The_Moon";
            The_Moon.Size = new Size(15, 15);
            The_Moon.SizeMode = PictureBoxSizeMode.StretchImage;
            The_Moon.TabIndex = 2;
            The_Moon.TabStop = false;
            // 
            // Mercury
            // 
            Mercury.Image = Properties.Resources.Mercury_Nasa;
            Mercury.Location = new Point(581, 187);
            Mercury.Name = "Mercury";
            Mercury.Size = new Size(20, 20);
            Mercury.SizeMode = PictureBoxSizeMode.StretchImage;
            Mercury.TabIndex = 3;
            Mercury.TabStop = false;
            // 
            // Pluto
            // 
            Pluto.Image = Properties.Resources.Pluto_in_True_Color___High_Res;
            Pluto.Location = new Point(1551, 187);
            Pluto.Name = "Pluto";
            Pluto.Size = new Size(10, 10);
            Pluto.SizeMode = PictureBoxSizeMode.StretchImage;
            Pluto.TabIndex = 4;
            Pluto.TabStop = false;
            // 
            // Days
            // 
            Days.AutoSize = true;
            Days.BackColor = SystemColors.AppWorkspace;
            Days.Location = new Point(66, 31);
            Days.Name = "Days";
            Days.Size = new Size(51, 25);
            Days.TabIndex = 5;
            Days.Text = "Days";
            // 
            // TickInterval
            // 
            TickInterval.Location = new Point(0, 0);
            TickInterval.Name = "TickInterval";
            TickInterval.Size = new Size(100, 23);
            TickInterval.TabIndex = 3;
            // 
            // FocusObject
            // 
            FocusObject.BackColor = SystemColors.AppWorkspace;
            FocusObject.DropDownStyle = ComboBoxStyle.DropDownList;
            FocusObject.Items.AddRange(new object[] { "sun", "mercury", "venus", "earth", "mars", "jupiter", "saturn", "uranus", "neptune", "pluto" });
            FocusObject.Location = new Point(66, 116);
            FocusObject.Name = "FocusObject";
            FocusObject.Size = new Size(182, 33);
            FocusObject.TabIndex = 2;
            FocusObject.TabStop = false;
            // 
            // Venus
            // 
            Venus.Image = Properties.Resources.Venus;
            Venus.Location = new Point(613, 187);
            Venus.Name = "Venus";
            Venus.Size = new Size(75, 75);
            Venus.SizeMode = PictureBoxSizeMode.StretchImage;
            Venus.TabIndex = 6;
            Venus.TabStop = false;
            // 
            // Mars
            // 
            Mars.Image = Properties.Resources.mars_v2;
            Mars.Location = new Point(772, 187);
            Mars.Name = "Mars";
            Mars.Size = new Size(75, 75);
            Mars.SizeMode = PictureBoxSizeMode.StretchImage;
            Mars.TabIndex = 7;
            Mars.TabStop = false;
            // 
            // Jupiter
            // 
            Jupiter.Image = Properties.Resources.Jupiter_OPAL_2024;
            Jupiter.Location = new Point(944, 187);
            Jupiter.Name = "Jupiter";
            Jupiter.Size = new Size(75, 75);
            Jupiter.SizeMode = PictureBoxSizeMode.StretchImage;
            Jupiter.TabIndex = 8;
            Jupiter.TabStop = false;
            // 
            // Saturn
            // 
            Saturn.Image = Properties.Resources.Saturn_during_Equinox;
            Saturn.Location = new Point(1067, 187);
            Saturn.Name = "Saturn";
            Saturn.Size = new Size(150, 75);
            Saturn.SizeMode = PictureBoxSizeMode.StretchImage;
            Saturn.TabIndex = 9;
            Saturn.TabStop = false;
            // 
            // Uranus
            // 
            Uranus.Image = Properties.Resources.Uranus_Nasa;
            Uranus.Location = new Point(1249, 187);
            Uranus.Name = "Uranus";
            Uranus.Size = new Size(75, 75);
            Uranus.SizeMode = PictureBoxSizeMode.StretchImage;
            Uranus.TabIndex = 10;
            Uranus.TabStop = false;
            // 
            // Neptune
            // 
            Neptune.Image = Properties.Resources.Neptune_Voyager2_color_calibrated;
            Neptune.Location = new Point(1352, 187);
            Neptune.Name = "Neptune";
            Neptune.Size = new Size(75, 75);
            Neptune.SizeMode = PictureBoxSizeMode.StretchImage;
            Neptune.TabIndex = 11;
            Neptune.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Desktop;
            ClientSize = new Size(2564, 1570);
            Controls.Add(Neptune);
            Controls.Add(Uranus);
            Controls.Add(Saturn);
            Controls.Add(Jupiter);
            Controls.Add(Mars);
            Controls.Add(Venus);
            Controls.Add(FocusObject);
            Controls.Add(TickInterval);
            Controls.Add(Days);
            Controls.Add(Pluto);
            Controls.Add(Mercury);
            Controls.Add(The_Moon);
            Controls.Add(Sun);
            Controls.Add(Earth);
            Name = "Form1";
            Text = "Solsystemet";
            ((System.ComponentModel.ISupportInitialize)Earth).EndInit();
            ((System.ComponentModel.ISupportInitialize)Sun).EndInit();
            ((System.ComponentModel.ISupportInitialize)The_Moon).EndInit();
            ((System.ComponentModel.ISupportInitialize)Mercury).EndInit();
            ((System.ComponentModel.ISupportInitialize)Pluto).EndInit();
            ((System.ComponentModel.ISupportInitialize)Venus).EndInit();
            ((System.ComponentModel.ISupportInitialize)Mars).EndInit();
            ((System.ComponentModel.ISupportInitialize)Jupiter).EndInit();
            ((System.ComponentModel.ISupportInitialize)Saturn).EndInit();
            ((System.ComponentModel.ISupportInitialize)Uranus).EndInit();
            ((System.ComponentModel.ISupportInitialize)Neptune).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox Earth;
        private PictureBox Sun;
        private PictureBox The_Moon;
        private PictureBox Mercury;
        private PictureBox Pluto;
        private Label Days;
        private Label TickInterval;
        private ComboBox FocusObject;
        private PictureBox Venus;
        private PictureBox Mars;
        private PictureBox Jupiter;
        private PictureBox Saturn;
        private PictureBox Uranus;
        private PictureBox Neptune;
    }
}
