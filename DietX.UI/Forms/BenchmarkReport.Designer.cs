namespace DietX.UI.Forms
{
    partial class BenchmarkReport
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
            button1 = new Button();
            button8 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.BackgroundImage = Properties.Resources.backpage;
            button1.BackgroundImageLayout = ImageLayout.Zoom;
            button1.FlatAppearance.BorderColor = Color.FromArgb(194, 194, 194);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(194, 194, 194);
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(194, 194, 194);
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.Gray;
            button1.Location = new Point(739, 536);
            button1.Name = "button1";
            button1.Size = new Size(53, 53);
            button1.TabIndex = 5;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
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
            button8.Location = new Point(12, 536);
            button8.Name = "button8";
            button8.Size = new Size(53, 53);
            button8.TabIndex = 22;
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // BenchmarkReport
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(804, 601);
            Controls.Add(button8);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "BenchmarkReport";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BenchmarkReport";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button8;
    }
}