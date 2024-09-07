namespace DietX.UI.Forms
{
    partial class Menu
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
            pictureBox2 = new PictureBox();
            lbl_User = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            lbl_Height = new Label();
            lbl_BMI = new Label();
            lbl_Weight = new Label();
            panel1 = new Panel();
            button2 = new Button();
            button3 = new Button();
            button5 = new Button();
            button8 = new Button();
            button1 = new Button();
            pictureBox3 = new PictureBox();
            panel2 = new Panel();
            panel3 = new Panel();
            pictureBox4 = new PictureBox();
            panel4 = new Panel();
            pictureBox5 = new PictureBox();
            panel5 = new Panel();
            pictureBox6 = new PictureBox();
            lbl_status = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.AccessibleRole = AccessibleRole.Application;
            pictureBox1.BackColor = SystemColors.ControlDark;
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.Menubackground;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(804, 601);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(12, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(76, 79);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // lbl_User
            // 
            lbl_User.AutoSize = true;
            lbl_User.BackColor = Color.FromArgb(38, 120, 1);
            lbl_User.FlatStyle = FlatStyle.Flat;
            lbl_User.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lbl_User.Location = new Point(14, 97);
            lbl_User.Name = "lbl_User";
            lbl_User.Size = new Size(61, 28);
            lbl_User.TabIndex = 3;
            lbl_User.Text = "USER";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 20F);
            label2.ForeColor = Color.BlueViolet;
            label2.Location = new Point(9, 18);
            label2.Name = "label2";
            label2.Size = new Size(139, 37);
            label2.TabIndex = 4;
            label2.Text = "HEIGHT :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Black", 20F);
            label3.ForeColor = SystemColors.Info;
            label3.Location = new Point(242, 18);
            label3.Name = "label3";
            label3.Size = new Size(145, 37);
            label3.TabIndex = 5;
            label3.Text = "WEIGHT :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Black", 20F);
            label4.ForeColor = Color.Yellow;
            label4.Location = new Point(486, 18);
            label4.Name = "label4";
            label4.Size = new Size(89, 37);
            label4.TabIndex = 6;
            label4.Text = "BMI :";
            // 
            // lbl_Height
            // 
            lbl_Height.AutoSize = true;
            lbl_Height.Font = new Font("Segoe UI Black", 20F);
            lbl_Height.ForeColor = Color.BlueViolet;
            lbl_Height.Location = new Point(143, 18);
            lbl_Height.Name = "lbl_Height";
            lbl_Height.Size = new Size(58, 37);
            lbl_Height.TabIndex = 7;
            lbl_Height.Text = "0.0";
            // 
            // lbl_BMI
            // 
            lbl_BMI.AutoSize = true;
            lbl_BMI.Font = new Font("Segoe UI Black", 20F);
            lbl_BMI.ForeColor = Color.Yellow;
            lbl_BMI.Location = new Point(570, 18);
            lbl_BMI.Name = "lbl_BMI";
            lbl_BMI.Size = new Size(58, 37);
            lbl_BMI.TabIndex = 8;
            lbl_BMI.Text = "0.0";
            // 
            // lbl_Weight
            // 
            lbl_Weight.AutoSize = true;
            lbl_Weight.Font = new Font("Segoe UI Black", 20F);
            lbl_Weight.ForeColor = SystemColors.Info;
            lbl_Weight.Location = new Point(384, 18);
            lbl_Weight.Name = "lbl_Weight";
            lbl_Weight.Size = new Size(58, 37);
            lbl_Weight.TabIndex = 9;
            lbl_Weight.Text = "0.0";
            // 
            // panel1
            // 
            panel1.BackColor = Color.OrangeRed;
            panel1.Controls.Add(lbl_BMI);
            panel1.Controls.Add(lbl_Weight);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(lbl_Height);
            panel1.Controls.Add(label4);
            panel1.ForeColor = SystemColors.ButtonHighlight;
            panel1.Location = new Point(94, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(700, 79);
            panel1.TabIndex = 10;
            // 
            // button2
            // 
            button2.BackColor = Color.Cyan;
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.Dock = DockStyle.Right;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI Black", 15F);
            button2.Location = new Point(82, 0);
            button2.Name = "button2";
            button2.Size = new Size(341, 69);
            button2.TabIndex = 11;
            button2.Text = "USER INFORMATION";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(255, 192, 255);
            button3.BackgroundImageLayout = ImageLayout.Stretch;
            button3.Dock = DockStyle.Right;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI Black", 15F);
            button3.Location = new Point(82, 0);
            button3.Name = "button3";
            button3.Size = new Size(342, 69);
            button3.TabIndex = 12;
            button3.Text = "REPORTS";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.Lime;
            button5.BackgroundImageLayout = ImageLayout.Stretch;
            button5.Dock = DockStyle.Right;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Segoe UI Black", 15F);
            button5.Location = new Point(82, 0);
            button5.Name = "button5";
            button5.Size = new Size(340, 69);
            button5.TabIndex = 14;
            button5.Text = "ADD FOOD";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button8
            // 
            button8.BackColor = Color.Red;
            button8.BackgroundImage = Properties.Resources.power_button;
            button8.BackgroundImageLayout = ImageLayout.Zoom;
            button8.FlatAppearance.BorderColor = Color.FromArgb(194, 194, 194);
            button8.FlatAppearance.BorderSize = 0;
            button8.FlatAppearance.MouseDownBackColor = Color.FromArgb(194, 194, 194);
            button8.FlatAppearance.MouseOverBackColor = Color.FromArgb(194, 194, 194);
            button8.FlatStyle = FlatStyle.Flat;
            button8.ForeColor = Color.Transparent;
            button8.Location = new Point(12, 548);
            button8.Name = "button8";
            button8.Size = new Size(53, 41);
            button8.TabIndex = 17;
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Gold;
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Dock = DockStyle.Right;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Black", 15F);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(81, 0);
            button1.Name = "button1";
            button1.Size = new Size(342, 69);
            button1.TabIndex = 18;
            button1.Text = "ADD MEAL";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Gold;
            pictureBox3.BackgroundImage = Properties.Resources.addmealicon1;
            pictureBox3.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox3.Dock = DockStyle.Left;
            pictureBox3.ErrorImage = null;
            pictureBox3.InitialImage = null;
            pictureBox3.Location = new Point(0, 0);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(83, 69);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 19;
            pictureBox3.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(pictureBox3);
            panel2.Controls.Add(button1);
            panel2.ForeColor = Color.Black;
            panel2.Location = new Point(172, 139);
            panel2.Name = "panel2";
            panel2.Size = new Size(425, 71);
            panel2.TabIndex = 20;
            // 
            // panel3
            // 
            panel3.BackgroundImageLayout = ImageLayout.Stretch;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(pictureBox4);
            panel3.Controls.Add(button2);
            panel3.ForeColor = Color.Black;
            panel3.Location = new Point(171, 245);
            panel3.Name = "panel3";
            panel3.Size = new Size(425, 71);
            panel3.TabIndex = 21;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.Cyan;
            pictureBox4.BackgroundImage = Properties.Resources.userinformation;
            pictureBox4.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox4.Dock = DockStyle.Left;
            pictureBox4.ErrorImage = null;
            pictureBox4.InitialImage = null;
            pictureBox4.Location = new Point(0, 0);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(83, 69);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 19;
            pictureBox4.TabStop = false;
            // 
            // panel4
            // 
            panel4.BackgroundImageLayout = ImageLayout.Stretch;
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(pictureBox5);
            panel4.Controls.Add(button3);
            panel4.ForeColor = Color.Black;
            panel4.Location = new Point(171, 356);
            panel4.Name = "panel4";
            panel4.Size = new Size(426, 71);
            panel4.TabIndex = 22;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.FromArgb(255, 192, 255);
            pictureBox5.BackgroundImage = Properties.Resources.reportsicon;
            pictureBox5.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox5.Dock = DockStyle.Left;
            pictureBox5.ErrorImage = null;
            pictureBox5.InitialImage = null;
            pictureBox5.Location = new Point(0, 0);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(82, 69);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 19;
            pictureBox5.TabStop = false;
            // 
            // panel5
            // 
            panel5.BackgroundImageLayout = ImageLayout.Stretch;
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(pictureBox6);
            panel5.Controls.Add(button5);
            panel5.ForeColor = Color.Black;
            panel5.Location = new Point(171, 464);
            panel5.Name = "panel5";
            panel5.Size = new Size(424, 71);
            panel5.TabIndex = 23;
            // 
            // pictureBox6
            // 
            pictureBox6.BackColor = Color.Lime;
            pictureBox6.BackgroundImage = Properties.Resources.addfoodicon;
            pictureBox6.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox6.Dock = DockStyle.Left;
            pictureBox6.ErrorImage = null;
            pictureBox6.InitialImage = null;
            pictureBox6.Location = new Point(0, 0);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(83, 69);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 19;
            pictureBox6.TabStop = false;
            // 
            // lbl_status
            // 
            lbl_status.AutoSize = true;
            lbl_status.BackColor = Color.Snow;
            lbl_status.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lbl_status.Location = new Point(190, 102);
            lbl_status.Name = "lbl_status";
            lbl_status.Size = new Size(124, 21);
            lbl_status.TabIndex = 24;
            lbl_status.Text = "Weight Status : ";
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(804, 601);
            Controls.Add(lbl_status);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(button8);
            Controls.Add(panel1);
            Controls.Add(lbl_User);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Menu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label lbl_User;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label lbl_Height;
        private Label lbl_BMI;
        private Label lbl_Weight;
        private Panel panel1;
        private Button button2;
        private Button button3;
        private Button button5;
        private Button button8;
        private Button button1;
        private PictureBox pictureBox3;
        private Panel panel2;
        private Panel panel3;
        private PictureBox pictureBox4;
        private Panel panel4;
        private PictureBox pictureBox5;
        private Panel panel5;
        private PictureBox pictureBox6;
        private Label lbl_status;
    }
}