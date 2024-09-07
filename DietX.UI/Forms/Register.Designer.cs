namespace DietX.UI.Forms
{
    partial class Register
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
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            txtEMail = new TextBox();
            txtPassword = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            label6 = new Label();
            dtpBirthDate = new DateTimePicker();
            label7 = new Label();
            chcFamela = new CheckBox();
            chcMale = new CheckBox();
            label4 = new Label();
            label8 = new Label();
            label9 = new Label();
            txtRepeatPassword = new TextBox();
            button_woc2 = new ePOSOne.btnProduct.Button_WOC();
            txtHeight = new TextBox();
            txtWeight = new TextBox();
            label10 = new Label();
            cm_Activity = new ComboBox();
            btnPasswordNoShow = new FontAwesome.Sharp.IconButton();
            btnReptPsswordShow = new FontAwesome.Sharp.IconButton();
            btnWarningIcon = new FontAwesome.Sharp.IconButton();
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
            button1.Location = new Point(597, 648);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(61, 71);
            button1.TabIndex = 1;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(607, 40);
            txtFirstName.Margin = new Padding(3, 4, 3, 4);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(218, 27);
            txtFirstName.TabIndex = 3;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(607, 107);
            txtLastName.Margin = new Padding(3, 4, 3, 4);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(218, 27);
            txtLastName.TabIndex = 4;
            // 
            // txtEMail
            // 
            txtEMail.Location = new Point(607, 373);
            txtEMail.Margin = new Padding(3, 4, 3, 4);
            txtEMail.Name = "txtEMail";
            txtEMail.Size = new Size(218, 27);
            txtEMail.TabIndex = 5;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(613, 481);
            txtPassword.Margin = new Padding(3, 4, 3, 4);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(218, 27);
            txtPassword.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft Tai Le", 11.25F, FontStyle.Bold);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(493, 40);
            label1.Name = "label1";
            label1.Size = new Size(115, 23);
            label1.TabIndex = 7;
            label1.Text = "First Name :";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Microsoft Tai Le", 11.25F, FontStyle.Bold);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(495, 107);
            label2.Name = "label2";
            label2.Size = new Size(112, 23);
            label2.TabIndex = 8;
            label2.Text = "Last Name :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Microsoft Tai Le", 11.25F, FontStyle.Bold);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(498, 173);
            label3.Name = "label3";
            label3.Size = new Size(109, 23);
            label3.TabIndex = 9;
            label3.Text = "Birth Date :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Microsoft Tai Le", 11.25F, FontStyle.Bold);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(530, 373);
            label5.Name = "label5";
            label5.Size = new Size(76, 23);
            label5.TabIndex = 11;
            label5.Text = "E-Mail :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Microsoft Tai Le", 11.25F, FontStyle.Bold);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(510, 481);
            label6.Name = "label6";
            label6.Size = new Size(105, 23);
            label6.TabIndex = 12;
            label6.Text = "Password :";
            // 
            // dtpBirthDate
            // 
            dtpBirthDate.CustomFormat = "yy:";
            dtpBirthDate.Location = new Point(607, 173);
            dtpBirthDate.Margin = new Padding(3, 4, 3, 4);
            dtpBirthDate.Name = "dtpBirthDate";
            dtpBirthDate.Size = new Size(218, 27);
            dtpBirthDate.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Microsoft Tai Le", 11.25F, FontStyle.Bold);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(511, 612);
            label7.Name = "label7";
            label7.Size = new Size(86, 23);
            label7.TabIndex = 15;
            label7.Text = "Gender :";
            // 
            // chcFamela
            // 
            chcFamela.AutoSize = true;
            chcFamela.BackColor = Color.Transparent;
            chcFamela.Font = new Font("Segoe UI", 9F);
            chcFamela.Location = new Point(646, 612);
            chcFamela.Margin = new Padding(3, 4, 3, 4);
            chcFamela.Name = "chcFamela";
            chcFamela.Size = new Size(79, 24);
            chcFamela.TabIndex = 16;
            chcFamela.Text = "Female";
            chcFamela.UseVisualStyleBackColor = false;
            // 
            // chcMale
            // 
            chcMale.AutoSize = true;
            chcMale.BackColor = Color.Transparent;
            chcMale.Font = new Font("Segoe UI", 9F);
            chcMale.Location = new Point(748, 612);
            chcMale.Margin = new Padding(3, 4, 3, 4);
            chcMale.Name = "chcMale";
            chcMale.Size = new Size(64, 24);
            chcMale.TabIndex = 17;
            chcMale.Text = "Male";
            chcMale.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Microsoft Tai Le", 11.25F, FontStyle.Bold);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(527, 240);
            label4.Name = "label4";
            label4.Size = new Size(80, 23);
            label4.TabIndex = 10;
            label4.Text = "Height :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Microsoft Tai Le", 11.25F, FontStyle.Bold);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(522, 307);
            label8.Name = "label8";
            label8.Size = new Size(84, 23);
            label8.TabIndex = 20;
            label8.Text = "Weight :";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Microsoft Tai Le", 11.25F, FontStyle.Bold);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(437, 532);
            label9.Name = "label9";
            label9.Size = new Size(171, 23);
            label9.TabIndex = 22;
            label9.Text = "Repeat Password :";
            // 
            // txtRepeatPassword
            // 
            txtRepeatPassword.Location = new Point(614, 532);
            txtRepeatPassword.Margin = new Padding(3, 4, 3, 4);
            txtRepeatPassword.Name = "txtRepeatPassword";
            txtRepeatPassword.Size = new Size(218, 27);
            txtRepeatPassword.TabIndex = 21;
            // 
            // button_woc2
            // 
            button_woc2.BackColor = Color.Transparent;
            button_woc2.BackgroundImageLayout = ImageLayout.Stretch;
            button_woc2.BorderColor = Color.Transparent;
            button_woc2.ButtonColor = Color.FromArgb(252, 164, 28);
            button_woc2.FlatAppearance.BorderSize = 0;
            button_woc2.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button_woc2.FlatStyle = FlatStyle.Flat;
            button_woc2.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            button_woc2.Location = new Point(698, 644);
            button_woc2.Margin = new Padding(3, 4, 3, 4);
            button_woc2.Name = "button_woc2";
            button_woc2.OnHoverBorderColor = Color.IndianRed;
            button_woc2.OnHoverButtonColor = Color.Orange;
            button_woc2.OnHoverTextColor = Color.Black;
            button_woc2.Size = new Size(141, 69);
            button_woc2.TabIndex = 43;
            button_woc2.Text = "SAVE";
            button_woc2.TextColor = Color.White;
            button_woc2.UseVisualStyleBackColor = false;
            button_woc2.Click += button_woc2_Click;
            // 
            // txtHeight
            // 
            txtHeight.Location = new Point(607, 236);
            txtHeight.Margin = new Padding(3, 4, 3, 4);
            txtHeight.Name = "txtHeight";
            txtHeight.Size = new Size(218, 27);
            txtHeight.TabIndex = 44;
            // 
            // txtWeight
            // 
            txtWeight.Location = new Point(607, 305);
            txtWeight.Margin = new Padding(3, 4, 3, 4);
            txtWeight.Name = "txtWeight";
            txtWeight.Size = new Size(218, 27);
            txtWeight.TabIndex = 45;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Microsoft Tai Le", 11.25F, FontStyle.Bold);
            label10.ForeColor = Color.Black;
            label10.Location = new Point(489, 428);
            label10.Name = "label10";
            label10.Size = new Size(88, 23);
            label10.TabIndex = 47;
            label10.Text = "Aktivity :";
            // 
            // cm_Activity
            // 
            cm_Activity.FormattingEnabled = true;
            cm_Activity.Location = new Point(621, 423);
            cm_Activity.Name = "cm_Activity";
            cm_Activity.Size = new Size(218, 28);
            cm_Activity.TabIndex = 48;
            // 
            // btnPasswordNoShow
            // 
            btnPasswordNoShow.BackColor = Color.Transparent;
            btnPasswordNoShow.BackgroundImageLayout = ImageLayout.Stretch;
            btnPasswordNoShow.FlatStyle = FlatStyle.Flat;
            btnPasswordNoShow.ForeColor = Color.FloralWhite;
            btnPasswordNoShow.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
            btnPasswordNoShow.IconColor = Color.DarkOrange;
            btnPasswordNoShow.IconFont = FontAwesome.Sharp.IconFont.Solid;
            btnPasswordNoShow.IconSize = 30;
            btnPasswordNoShow.Location = new Point(855, 479);
            btnPasswordNoShow.Name = "btnPasswordNoShow";
            btnPasswordNoShow.Size = new Size(33, 30);
            btnPasswordNoShow.TabIndex = 49;
            btnPasswordNoShow.UseVisualStyleBackColor = false;
            btnPasswordNoShow.Click += btnPasswordNoShow_Click;
            // 
            // btnReptPsswordShow
            // 
            btnReptPsswordShow.BackColor = Color.Transparent;
            btnReptPsswordShow.BackgroundImageLayout = ImageLayout.Stretch;
            btnReptPsswordShow.FlatStyle = FlatStyle.Flat;
            btnReptPsswordShow.ForeColor = Color.FloralWhite;
            btnReptPsswordShow.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
            btnReptPsswordShow.IconColor = Color.DarkOrange;
            btnReptPsswordShow.IconFont = FontAwesome.Sharp.IconFont.Solid;
            btnReptPsswordShow.IconSize = 30;
            btnReptPsswordShow.Location = new Point(855, 529);
            btnReptPsswordShow.Name = "btnReptPsswordShow";
            btnReptPsswordShow.Size = new Size(33, 30);
            btnReptPsswordShow.TabIndex = 50;
            btnReptPsswordShow.UseVisualStyleBackColor = false;
            btnReptPsswordShow.Click += btnReptPsswordShow_Click;
            // 
            // btnWarningIcon
            // 
            btnWarningIcon.BackColor = Color.Transparent;
            btnWarningIcon.FlatStyle = FlatStyle.Flat;
            btnWarningIcon.ForeColor = Color.WhiteSmoke;
            btnWarningIcon.IconChar = FontAwesome.Sharp.IconChar.InfoCircle;
            btnWarningIcon.IconColor = Color.DarkOrange;
            btnWarningIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnWarningIcon.IconSize = 35;
            btnWarningIcon.Location = new Point(613, 566);
            btnWarningIcon.Name = "btnWarningIcon";
            btnWarningIcon.Size = new Size(40, 29);
            btnWarningIcon.TabIndex = 94;
            btnWarningIcon.UseVisualStyleBackColor = false;
            btnWarningIcon.Click += btnWarningIcon_Click;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            BackgroundImage = Properties.Resources.RegisterBackGround;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(919, 801);
            Controls.Add(btnWarningIcon);
            Controls.Add(btnReptPsswordShow);
            Controls.Add(btnPasswordNoShow);
            Controls.Add(cm_Activity);
            Controls.Add(label10);
            Controls.Add(txtWeight);
            Controls.Add(txtHeight);
            Controls.Add(button_woc2);
            Controls.Add(label9);
            Controls.Add(txtRepeatPassword);
            Controls.Add(label8);
            Controls.Add(chcMale);
            Controls.Add(chcFamela);
            Controls.Add(label7);
            Controls.Add(dtpBirthDate);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtPassword);
            Controls.Add(txtEMail);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            Controls.Add(button1);
            ForeColor = Color.Transparent;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "Register";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Register";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private TextBox txtEMail;
        private TextBox txtPassword;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label5;
        private Label label6;
        private DateTimePicker dtpBirthDate;
        private Label label7;
        private CheckBox chcFamela;
        private CheckBox chcMale;
        private Label label4;
        private Label label8;
        private Label label9;
        private TextBox txtRepeatPassword;
        private ePOSOne.btnProduct.Button_WOC button_woc2;
        private TextBox txtHeight;
        private TextBox txtWeight;
        private Label label10;
        private ComboBox cm_Activity;
        private FontAwesome.Sharp.IconButton btnPasswordNoShow;
        private FontAwesome.Sharp.IconButton btnReptPsswordShow;
        private FontAwesome.Sharp.IconButton btnWarningIcon;
    }
}