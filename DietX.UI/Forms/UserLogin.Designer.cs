namespace DietX.UI.Forms
{
    partial class UserLogin
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
            txt_Email = new TextBox();
            txt_Password = new TextBox();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            button_woc1 = new ePOSOne.btnProduct.Button_WOC();
            btnPasswordNoShow = new FontAwesome.Sharp.IconButton();
            ıconButton1 = new FontAwesome.Sharp.IconButton();
            SuspendLayout();
            // 
            // txt_Email
            // 
            txt_Email.Location = new Point(521, 245);
            txt_Email.Margin = new Padding(3, 4, 3, 4);
            txt_Email.Name = "txt_Email";
            txt_Email.Size = new Size(242, 27);
            txt_Email.TabIndex = 0;
            // 
            // txt_Password
            // 
            txt_Password.Location = new Point(521, 363);
            txt_Password.Margin = new Padding(3, 4, 3, 4);
            txt_Password.Name = "txt_Password";
            txt_Password.Size = new Size(242, 27);
            txt_Password.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Black", 11F);
            label1.ForeColor = Color.FromArgb(255, 128, 0);
            label1.Location = new Point(522, 208);
            label1.Name = "label1";
            label1.Size = new Size(72, 25);
            label1.TabIndex = 4;
            label1.Text = "E-Mail";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Black", 11F);
            label2.ForeColor = Color.FromArgb(255, 128, 0);
            label2.Location = new Point(522, 327);
            label2.Name = "label2";
            label2.Size = new Size(101, 25);
            label2.TabIndex = 5;
            label2.Text = "Password";
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.BackgroundImage = Properties.Resources.backpage;
            button1.BackgroundImageLayout = ImageLayout.Zoom;
            button1.FlatAppearance.BorderColor = Color.Red;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.Transparent;
            button1.Location = new Point(529, 489);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(61, 71);
            button1.TabIndex = 6;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button_woc1
            // 
            button_woc1.BackColor = Color.Transparent;
            button_woc1.BackgroundImageLayout = ImageLayout.Stretch;
            button_woc1.BorderColor = Color.Transparent;
            button_woc1.ButtonColor = Color.LimeGreen;
            button_woc1.FlatAppearance.BorderSize = 0;
            button_woc1.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button_woc1.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button_woc1.FlatStyle = FlatStyle.Flat;
            button_woc1.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            button_woc1.ForeColor = Color.Transparent;
            button_woc1.Location = new Point(614, 488);
            button_woc1.Margin = new Padding(3, 4, 3, 4);
            button_woc1.Name = "button_woc1";
            button_woc1.OnHoverBorderColor = Color.BlueViolet;
            button_woc1.OnHoverButtonColor = Color.Lime;
            button_woc1.OnHoverTextColor = Color.Black;
            button_woc1.Size = new Size(141, 71);
            button_woc1.TabIndex = 38;
            button_woc1.Text = "SIGN IN";
            button_woc1.TextColor = Color.White;
            button_woc1.UseVisualStyleBackColor = false;
            button_woc1.Click += button_woc1_Click;
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
            btnPasswordNoShow.Location = new Point(782, 363);
            btnPasswordNoShow.Name = "btnPasswordNoShow";
            btnPasswordNoShow.Size = new Size(33, 30);
            btnPasswordNoShow.TabIndex = 25;
            btnPasswordNoShow.UseVisualStyleBackColor = false;
            // 
            // ıconButton1
            // 
            ıconButton1.BackColor = Color.Transparent;
            ıconButton1.FlatStyle = FlatStyle.Flat;
            ıconButton1.ForeColor = Color.WhiteSmoke;
            ıconButton1.IconChar = FontAwesome.Sharp.IconChar.InfoCircle;
            ıconButton1.IconColor = Color.DarkOrange;
            ıconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ıconButton1.IconSize = 40;
            ıconButton1.Location = new Point(521, 397);
            ıconButton1.Name = "ıconButton1";
            ıconButton1.Size = new Size(40, 29);
            ıconButton1.TabIndex = 93;
            ıconButton1.UseVisualStyleBackColor = false;
            // 
            // UserLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.LoginBackground;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(919, 801);
            Controls.Add(ıconButton1);
            Controls.Add(btnPasswordNoShow);
            Controls.Add(button_woc1);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txt_Password);
            Controls.Add(txt_Email);
            ForeColor = Color.Transparent;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "UserLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UserLogin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_Email;
        private TextBox txt_Password;
        private Label label1;
        private Label label2;
        private Button button1;
        private ePOSOne.btnProduct.Button_WOC button_woc1;
        private FontAwesome.Sharp.IconButton btnPasswordNoShow;
        private FontAwesome.Sharp.IconButton ıconButton1;
    }
}