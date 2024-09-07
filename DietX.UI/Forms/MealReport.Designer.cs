namespace DietX.UI.Forms
{
    partial class MealReport
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
            button_woc1 = new ePOSOne.btnProduct.Button_WOC();
            button_woc2 = new ePOSOne.btnProduct.Button_WOC();
            dgw_Report = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgw_Report).BeginInit();
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
            button1.ForeColor = Color.Transparent;
            button1.Location = new Point(832, 712);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(61, 71);
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
            button8.Location = new Point(14, 715);
            button8.Margin = new Padding(3, 4, 3, 4);
            button8.Name = "button8";
            button8.Size = new Size(61, 71);
            button8.TabIndex = 21;
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // button_woc1
            // 
            button_woc1.BackColor = Color.Transparent;
            button_woc1.BackgroundImageLayout = ImageLayout.Stretch;
            button_woc1.BorderColor = Color.Transparent;
            button_woc1.ButtonColor = Color.DarkSlateGray;
            button_woc1.FlatAppearance.BorderSize = 0;
            button_woc1.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button_woc1.FlatStyle = FlatStyle.Flat;
            button_woc1.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            button_woc1.Location = new Point(582, 197);
            button_woc1.Margin = new Padding(3, 4, 3, 4);
            button_woc1.Name = "button_woc1";
            button_woc1.OnHoverBorderColor = Color.IndianRed;
            button_woc1.OnHoverButtonColor = Color.LightSteelBlue;
            button_woc1.OnHoverTextColor = Color.Black;
            button_woc1.Size = new Size(311, 69);
            button_woc1.TabIndex = 44;
            button_woc1.Text = "MEALS MONTHLY";
            button_woc1.TextColor = Color.White;
            button_woc1.UseVisualStyleBackColor = false;
            button_woc1.Click += button_woc1_Click;
            // 
            // button_woc2
            // 
            button_woc2.BackColor = Color.Transparent;
            button_woc2.BackgroundImageLayout = ImageLayout.Stretch;
            button_woc2.BorderColor = Color.Transparent;
            button_woc2.ButtonColor = Color.RoyalBlue;
            button_woc2.FlatAppearance.BorderSize = 0;
            button_woc2.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button_woc2.FlatStyle = FlatStyle.Flat;
            button_woc2.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            button_woc2.Location = new Point(245, 197);
            button_woc2.Margin = new Padding(3, 4, 3, 4);
            button_woc2.Name = "button_woc2";
            button_woc2.OnHoverBorderColor = Color.BlueViolet;
            button_woc2.OnHoverButtonColor = Color.CornflowerBlue;
            button_woc2.OnHoverTextColor = Color.Black;
            button_woc2.Size = new Size(311, 69);
            button_woc2.TabIndex = 43;
            button_woc2.Text = "MEALS WEEKLEY";
            button_woc2.TextColor = Color.White;
            button_woc2.UseVisualStyleBackColor = false;
            button_woc2.Click += button_woc2_Click;
            // 
            // dgw_Report
            // 
            dgw_Report.BackgroundColor = SystemColors.ButtonFace;
            dgw_Report.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgw_Report.GridColor = SystemColors.InactiveBorder;
            dgw_Report.Location = new Point(245, 301);
            dgw_Report.Margin = new Padding(3, 4, 3, 4);
            dgw_Report.MultiSelect = false;
            dgw_Report.Name = "dgw_Report";
            dgw_Report.ReadOnly = true;
            dgw_Report.RowHeadersWidth = 51;
            dgw_Report.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgw_Report.Size = new Size(648, 367);
            dgw_Report.TabIndex = 45;
            // 
            // MealReport
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.diet_jpeg__x_1;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(957, 801);
            Controls.Add(dgw_Report);
            Controls.Add(button_woc1);
            Controls.Add(button_woc2);
            Controls.Add(button8);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "MealReport";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MealReport";
            ((System.ComponentModel.ISupportInitialize)dgw_Report).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button8;
        private ePOSOne.btnProduct.Button_WOC button_woc1;
        private ePOSOne.btnProduct.Button_WOC button_woc2;
        private DataGridView dgw_Report;
    }
}