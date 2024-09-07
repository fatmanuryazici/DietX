namespace DietX.UI.Forms
{
    partial class Entrance
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            button2 = new Button();
            pictureBox2 = new PictureBox();
            button1 = new Button();
            pictureBox4 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.entrance;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(804, 601);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Palatino Linotype", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button2.Location = new Point(455, 361);
            button2.Name = "button2";
            button2.Size = new Size(201, 52);
            button2.TabIndex = 2;
            button2.Text = "SIGN UP";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.userslogo;
            pictureBox2.Location = new Point(388, 294);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(68, 52);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Palatino Linotype", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button1.Location = new Point(455, 294);
            button1.Name = "button1";
            button1.Size = new Size(201, 52);
            button1.TabIndex = 5;
            button1.Text = "ALREADY HAVE AN ACCOUNT ?";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.ErrorImage = null;
            pictureBox4.Image = Properties.Resources.registerlogo;
            pictureBox4.InitialImage = null;
            pictureBox4.Location = new Point(388, 361);
            pictureBox4.Margin = new Padding(3, 8, 3, 8);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Padding = new Padding(0, 8, 0, 8);
            pictureBox4.Size = new Size(68, 52);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 7;
            pictureBox4.TabStop = false;
            // 
            // Entrance
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(804, 601);
            Controls.Add(pictureBox4);
            Controls.Add(button1);
            Controls.Add(pictureBox2);
            Controls.Add(button2);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Entrance";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Entrance";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Button button2;
        private PictureBox pictureBox2;
        private Button button1;
        private PictureBox pictureBox4;
    }
}