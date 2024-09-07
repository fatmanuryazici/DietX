namespace DietX.UI.Forms
{
    partial class UserInformation
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
            button8 = new Button();
            label8 = new Label();
            txtWeight = new NumericUpDown();
            button_woc1 = new ePOSOne.btnProduct.Button_WOC();
            txtHeight = new NumericUpDown();
            dtpBirthDate = new DateTimePicker();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtEMail = new TextBox();
            txtLastName = new TextBox();
            txtFirstName = new TextBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)txtWeight).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtHeight).BeginInit();
            SuspendLayout();
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
            button8.Location = new Point(864, 575);
            button8.Margin = new Padding(3, 4, 3, 4);
            button8.Name = "button8";
            button8.Size = new Size(61, 71);
            button8.TabIndex = 20;
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Microsoft Tai Le", 11.25F, FontStyle.Bold);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(561, 293);
            label8.Name = "label8";
            label8.Size = new Size(84, 23);
            label8.TabIndex = 39;
            label8.Text = "Weight :";
            // 
            // txtWeight
            // 
            txtWeight.Location = new Point(646, 293);
            txtWeight.Margin = new Padding(3, 4, 3, 4);
            txtWeight.Name = "txtWeight";
            txtWeight.Size = new Size(218, 27);
            txtWeight.TabIndex = 38;
            // 
            // button_woc1
            // 
            button_woc1.BackColor = Color.Transparent;
            button_woc1.BackgroundImageLayout = ImageLayout.Stretch;
            button_woc1.BorderColor = Color.Transparent;
            button_woc1.ButtonColor = Color.LimeGreen;
            button_woc1.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
            button_woc1.FlatAppearance.BorderSize = 0;
            button_woc1.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button_woc1.FlatStyle = FlatStyle.Flat;
            button_woc1.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            button_woc1.Location = new Point(743, 467);
            button_woc1.Margin = new Padding(3, 4, 3, 4);
            button_woc1.Name = "button_woc1";
            button_woc1.OnHoverBorderColor = Color.BlueViolet;
            button_woc1.OnHoverButtonColor = Color.Lime;
            button_woc1.OnHoverTextColor = Color.Black;
            button_woc1.Size = new Size(141, 71);
            button_woc1.TabIndex = 37;
            button_woc1.Text = "CHANGE";
            button_woc1.TextColor = Color.White;
            button_woc1.UseVisualStyleBackColor = false;
            // 
            // txtHeight
            // 
            txtHeight.Location = new Point(646, 227);
            txtHeight.Margin = new Padding(3, 4, 3, 4);
            txtHeight.Name = "txtHeight";
            txtHeight.Size = new Size(218, 27);
            txtHeight.TabIndex = 33;
            // 
            // dtpBirthDate
            // 
            dtpBirthDate.CustomFormat = "yy:";
            dtpBirthDate.Location = new Point(646, 160);
            dtpBirthDate.Margin = new Padding(3, 4, 3, 4);
            dtpBirthDate.Name = "dtpBirthDate";
            dtpBirthDate.Size = new Size(218, 27);
            dtpBirthDate.TabIndex = 32;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Microsoft Tai Le", 11.25F, FontStyle.Bold);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(569, 360);
            label5.Name = "label5";
            label5.Size = new Size(76, 23);
            label5.TabIndex = 30;
            label5.Text = "E-Mail :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Microsoft Tai Le", 11.25F, FontStyle.Bold);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(566, 227);
            label4.Name = "label4";
            label4.Size = new Size(80, 23);
            label4.TabIndex = 29;
            label4.Text = "Height :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Microsoft Tai Le", 11.25F, FontStyle.Bold);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(537, 160);
            label3.Name = "label3";
            label3.Size = new Size(109, 23);
            label3.TabIndex = 28;
            label3.Text = "Birth Date :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Microsoft Tai Le", 11.25F, FontStyle.Bold);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(534, 93);
            label2.Name = "label2";
            label2.Size = new Size(112, 23);
            label2.TabIndex = 27;
            label2.Text = "Last Name :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft Tai Le", 11.25F, FontStyle.Bold);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(531, 27);
            label1.Name = "label1";
            label1.Size = new Size(115, 23);
            label1.TabIndex = 26;
            label1.Text = "First Name :";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtEMail
            // 
            txtEMail.Location = new Point(646, 360);
            txtEMail.Margin = new Padding(3, 4, 3, 4);
            txtEMail.Name = "txtEMail";
            txtEMail.Size = new Size(218, 27);
            txtEMail.TabIndex = 24;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(646, 93);
            txtLastName.Margin = new Padding(3, 4, 3, 4);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(218, 27);
            txtLastName.TabIndex = 23;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(646, 27);
            txtFirstName.Margin = new Padding(3, 4, 3, 4);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(218, 27);
            txtFirstName.TabIndex = 22;
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
            button1.Location = new Point(646, 467);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(61, 71);
            button1.TabIndex = 21;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // UserInformation
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.RegisterBackGround;
            ClientSize = new Size(951, 801);
            Controls.Add(label8);
            Controls.Add(txtWeight);
            Controls.Add(button_woc1);
            Controls.Add(txtHeight);
            Controls.Add(dtpBirthDate);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtEMail);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            Controls.Add(button1);
            Controls.Add(button8);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "UserInformation";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UserInformation";
            ((System.ComponentModel.ISupportInitialize)txtWeight).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtHeight).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button8;
        private Label label8;
        private NumericUpDown txtWeight;
        private ePOSOne.btnProduct.Button_WOC button_woc1;
        private NumericUpDown txtHeight;
        private DateTimePicker dtpBirthDate;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtEMail;
        private TextBox txtLastName;
        private TextBox txtFirstName;
        private Button button1;
    }
}