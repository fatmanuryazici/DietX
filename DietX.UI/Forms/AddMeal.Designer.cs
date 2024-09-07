namespace DietX.UI.Forms
{
    partial class AddMeal
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
            components = new System.ComponentModel.Container();
            button1 = new Button();
            dgw_EatReport = new DataGridView();
            cm_eatReport = new ContextMenuStrip(components);
            deleteToolStripMenuItem = new ToolStripMenuItem();
            updateToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            date_eat = new DateTimePicker();
            num_Measure = new NumericUpDown();
            cb_Meal = new ComboBox();
            cb_Categories = new ComboBox();
            cb_Food = new ComboBox();
            button8 = new Button();
            pictureFood = new PictureBox();
            button_woc2 = new ePOSOne.btnProduct.Button_WOC();
            button_woc1 = new ePOSOne.btnProduct.Button_WOC();
            label7 = new Label();
            lbl_PorsionType = new Label();
            ((System.ComponentModel.ISupportInitialize)dgw_EatReport).BeginInit();
            cm_eatReport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)num_Measure).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureFood).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.BackgroundImage = Properties.Resources.backpage;
            button1.BackgroundImageLayout = ImageLayout.Zoom;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.Transparent;
            button1.Location = new Point(36, 289);
            button1.Name = "button1";
            button1.Size = new Size(72, 53);
            button1.TabIndex = 3;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // dgw_EatReport
            // 
            dgw_EatReport.BackgroundColor = SystemColors.Control;
            dgw_EatReport.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgw_EatReport.ContextMenuStrip = cm_eatReport;
            dgw_EatReport.GridColor = Color.FromArgb(216, 202, 183);
            dgw_EatReport.Location = new Point(17, 360);
            dgw_EatReport.MultiSelect = false;
            dgw_EatReport.Name = "dgw_EatReport";
            dgw_EatReport.ReadOnly = true;
            dgw_EatReport.RowHeadersWidth = 51;
            dgw_EatReport.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgw_EatReport.Size = new Size(775, 232);
            dgw_EatReport.TabIndex = 4;
            // 
            // cm_eatReport
            // 
            cm_eatReport.ImageScalingSize = new Size(20, 20);
            cm_eatReport.Items.AddRange(new ToolStripItem[] { deleteToolStripMenuItem, updateToolStripMenuItem });
            cm_eatReport.Name = "cm_eatReport";
            cm_eatReport.Size = new Size(113, 48);
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(112, 22);
            deleteToolStripMenuItem.Text = "Delete";
            deleteToolStripMenuItem.Click += deleteToolStripMenuItem_Click;
            // 
            // updateToolStripMenuItem
            // 
            updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            updateToolStripMenuItem.Size = new Size(112, 22);
            updateToolStripMenuItem.Text = "Update";
            updateToolStripMenuItem.Click += updateToolStripMenuItem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(59, 31);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 5;
            label1.Text = "DATE :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(57, 73);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 6;
            label2.Text = "MEAL :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(18, 118);
            label3.Name = "label3";
            label3.Size = new Size(83, 15);
            label3.TabIndex = 7;
            label3.Text = "CATEGORIES :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.Location = new Point(52, 163);
            label4.Name = "label4";
            label4.Size = new Size(49, 15);
            label4.TabIndex = 8;
            label4.Text = "FOOD  :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.Location = new Point(33, 207);
            label5.Name = "label5";
            label5.Size = new Size(68, 15);
            label5.TabIndex = 9;
            label5.Text = "MEASURE :";
            // 
            // date_eat
            // 
            date_eat.Location = new Point(114, 25);
            date_eat.Name = "date_eat";
            date_eat.Size = new Size(244, 23);
            date_eat.TabIndex = 10;
            // 
            // num_Measure
            // 
            num_Measure.Location = new Point(114, 205);
            num_Measure.Name = "num_Measure";
            num_Measure.Size = new Size(244, 23);
            num_Measure.TabIndex = 11;
            // 
            // cb_Meal
            // 
            cb_Meal.FormattingEnabled = true;
            cb_Meal.Location = new Point(114, 70);
            cb_Meal.Name = "cb_Meal";
            cb_Meal.Size = new Size(244, 23);
            cb_Meal.TabIndex = 12;
            // 
            // cb_Categories
            // 
            cb_Categories.FormattingEnabled = true;
            cb_Categories.Location = new Point(114, 115);
            cb_Categories.Name = "cb_Categories";
            cb_Categories.Size = new Size(244, 23);
            cb_Categories.TabIndex = 13;
            cb_Categories.SelectedIndexChanged += cb_Categories_SelectedIndexChanged;
            // 
            // cb_Food
            // 
            cb_Food.FormattingEnabled = true;
            cb_Food.Location = new Point(114, 160);
            cb_Food.Name = "cb_Food";
            cb_Food.Size = new Size(244, 23);
            cb_Food.TabIndex = 14;
            cb_Food.SelectedIndexChanged += cb_Food_SelectedIndexChanged;
            // 
            // button8
            // 
            button8.BackColor = Color.Red;
            button8.BackgroundImage = Properties.Resources.power_button;
            button8.BackgroundImageLayout = ImageLayout.Stretch;
            button8.FlatAppearance.BorderColor = Color.FromArgb(194, 194, 194);
            button8.FlatAppearance.BorderSize = 0;
            button8.FlatAppearance.MouseDownBackColor = Color.FromArgb(194, 194, 194);
            button8.FlatAppearance.MouseOverBackColor = Color.FromArgb(194, 194, 194);
            button8.FlatStyle = FlatStyle.Flat;
            button8.ForeColor = Color.Transparent;
            button8.Location = new Point(561, 288);
            button8.Name = "button8";
            button8.Size = new Size(53, 53);
            button8.TabIndex = 18;
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // pictureFood
            // 
            pictureFood.BackColor = Color.Transparent;
            pictureFood.BorderStyle = BorderStyle.Fixed3D;
            pictureFood.Location = new Point(377, 73);
            pictureFood.Name = "pictureFood";
            pictureFood.Size = new Size(178, 155);
            pictureFood.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureFood.TabIndex = 19;
            pictureFood.TabStop = false;
            // 
            // button_woc2
            // 
            button_woc2.BackColor = Color.Transparent;
            button_woc2.BackgroundImageLayout = ImageLayout.Stretch;
            button_woc2.BorderColor = Color.Transparent;
            button_woc2.ButtonColor = Color.LimeGreen;
            button_woc2.FlatAppearance.BorderSize = 0;
            button_woc2.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button_woc2.FlatStyle = FlatStyle.Flat;
            button_woc2.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            button_woc2.Location = new Point(235, 289);
            button_woc2.Name = "button_woc2";
            button_woc2.OnHoverBorderColor = Color.BlueViolet;
            button_woc2.OnHoverButtonColor = Color.Lime;
            button_woc2.OnHoverTextColor = Color.Black;
            button_woc2.Size = new Size(123, 52);
            button_woc2.TabIndex = 41;
            button_woc2.Text = "SAVE";
            button_woc2.TextColor = Color.White;
            button_woc2.UseVisualStyleBackColor = false;
            button_woc2.Click += button_woc2_Click;
            // 
            // button_woc1
            // 
            button_woc1.BackColor = Color.Transparent;
            button_woc1.BackgroundImageLayout = ImageLayout.Stretch;
            button_woc1.BorderColor = Color.Transparent;
            button_woc1.ButtonColor = Color.FromArgb(252, 164, 28);
            button_woc1.FlatAppearance.BorderSize = 0;
            button_woc1.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button_woc1.FlatStyle = FlatStyle.Flat;
            button_woc1.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            button_woc1.Location = new Point(114, 289);
            button_woc1.Name = "button_woc1";
            button_woc1.OnHoverBorderColor = Color.IndianRed;
            button_woc1.OnHoverButtonColor = Color.Orange;
            button_woc1.OnHoverTextColor = Color.Black;
            button_woc1.Size = new Size(123, 52);
            button_woc1.TabIndex = 42;
            button_woc1.Text = "UPDATE";
            button_woc1.TextColor = Color.White;
            button_woc1.UseVisualStyleBackColor = false;
            button_woc1.Click += button_woc1_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label7.Location = new Point(437, 31);
            label7.Name = "label7";
            label7.Size = new Size(61, 21);
            label7.TabIndex = 43;
            label7.Text = "IMAGE";
            // 
            // lbl_PorsionType
            // 
            lbl_PorsionType.AutoSize = true;
            lbl_PorsionType.Location = new Point(377, 239);
            lbl_PorsionType.Name = "lbl_PorsionType";
            lbl_PorsionType.Size = new Size(74, 15);
            lbl_PorsionType.TabIndex = 44;
            lbl_PorsionType.Text = "Porsion Type";
            // 
            // AddMeal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BackgroundImage = Properties.Resources.AddMeal21;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(804, 601);
            Controls.Add(lbl_PorsionType);
            Controls.Add(label7);
            Controls.Add(button_woc1);
            Controls.Add(button_woc2);
            Controls.Add(pictureFood);
            Controls.Add(button8);
            Controls.Add(cb_Food);
            Controls.Add(cb_Categories);
            Controls.Add(cb_Meal);
            Controls.Add(num_Measure);
            Controls.Add(date_eat);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgw_EatReport);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "AddMeal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddMeal";
            ((System.ComponentModel.ISupportInitialize)dgw_EatReport).EndInit();
            cm_eatReport.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)num_Measure).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureFood).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private DataGridView dgw_EatReport;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private DateTimePicker date_eat;
        private NumericUpDown num_Measure;
        private ComboBox cb_Meal;
        private ComboBox cb_Categories;
        private ComboBox cb_Food;
        private Button button8;
        private PictureBox pictureFood;
        private ePOSOne.btnProduct.Button_WOC button_woc2;
        private ePOSOne.btnProduct.Button_WOC button_woc1;
        private Label label7;
        private ContextMenuStrip cm_eatReport;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private ToolStripMenuItem updateToolStripMenuItem;
        private Label lbl_PorsionType;
    }
}