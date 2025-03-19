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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Earth = new PictureBox();
            Sun = new PictureBox();
            The_Moon = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)Earth).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Sun).BeginInit();
            ((System.ComponentModel.ISupportInitialize)The_Moon).BeginInit();
            SuspendLayout();
            // 
            // Earth
            // 
            Earth.BackColor = SystemColors.Control;
            Earth.Image = (Image)resources.GetObject("Earth.Image");
            Earth.ImageLocation = "";
            Earth.Location = new Point(583, 187);
            Earth.MaximumSize = new Size(100, 100);
            Earth.Name = "Earth";
            Earth.Size = new Size(100, 75);
            Earth.SizeMode = PictureBoxSizeMode.StretchImage;
            Earth.TabIndex = 0;
            Earth.TabStop = false;
            // 
            // Sun
            // 
            Sun.Image = (Image)resources.GetObject("Sun.Image");
            Sun.Location = new Point(342, 187);
            Sun.MaximumSize = new Size(200, 200);
            Sun.Name = "Sun";
            Sun.Size = new Size(200, 200);
            Sun.SizeMode = PictureBoxSizeMode.StretchImage;
            Sun.TabIndex = 1;
            Sun.TabStop = false;
            // 
            // The_Moon
            // 
            The_Moon.Image = (Image)resources.GetObject("The_Moon.Image");
            The_Moon.Location = new Point(883, 187);
            The_Moon.Name = "The_Moon";
            The_Moon.Size = new Size(74, 75);
            The_Moon.SizeMode = PictureBoxSizeMode.StretchImage;
            The_Moon.TabIndex = 2;
            The_Moon.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Desktop;
            ClientSize = new Size(2478, 1570);
            Controls.Add(The_Moon);
            Controls.Add(Sun);
            Controls.Add(Earth);
            Name = "Form1";
            Text = "Solsystemet";
            ((System.ComponentModel.ISupportInitialize)Earth).EndInit();
            ((System.ComponentModel.ISupportInitialize)Sun).EndInit();
            ((System.ComponentModel.ISupportInitialize)The_Moon).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox Earth;
        private PictureBox Sun;
        private PictureBox The_Moon;
    }
}
