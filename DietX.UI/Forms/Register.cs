using DietX.BLL.UserBusinessService;
using DietX.Entities.Entities.UserEntities;
using DietX.Entities.Enums;
using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DietX.UI.Forms
{
    public partial class Register : Form
    {
        private readonly IUserService _userService;
        public Register()
        {
            InitializeComponent();
            _userService = new UserService();
            GetAllActivity();

        }

        private void GetAllActivity()
        {
            cm_Activity.DataSource = Enum.GetValues(typeof(ActivityLevel));
            cm_Activity.DisplayMember ="ToString";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Entrance entrance = new Entrance();
            entrance.Show();
            this.Close();

        }

        private void button_woc2_Click(object sender, EventArgs e)
        {
            User newUser = new User();

            if (chcMale.Checked)
            {
                newUser.Gender = Gender.Male;
            }
            else if (chcFamela.Checked)
            {
                newUser.Gender = Gender.Female;
            }
            else
            {
                MessageBox.Show("Please choose gender!");
                return;
            }
            newUser.FirstName = txtFirstName.Text;
            newUser.LastName = txtLastName.Text;
            newUser.BirthDate = dtpBirthDate.Value;
            newUser.Height = Convert.ToDouble(txtHeight.Text);
            newUser.Weight = Convert.ToDouble(txtWeight.Text);
            newUser.Email = txtEMail.Text;

            // Aktivite seviyesini dönüştürme işlemi
            if (Enum.TryParse(cm_Activity.SelectedItem.ToString(), out ActivityLevel selectedActivityLevel))
            {
                newUser.ActivityLevel = selectedActivityLevel;
            }
            else
            {
                MessageBox.Show("Invalid activity level!");
                return;
            }


            string password = txtPassword.Text.Trim();
            string reenteredPassword = txtRepeatPassword.Text.Trim();
            if (_userService.ExistEmail(newUser.Email))
            {
                MessageBox.Show("This e-mail is already taken. Please try another e-mail.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!_userService.IsPasswordValid(password))
            {
                MessageBox.Show("Password is nor walid. Follow the rules.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (password != reenteredPassword)
            {
                MessageBox.Show("Password is not match. Please enter the right password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            newUser.Password = HashPass(password).Trim();
            try
            {
                _userService.Add(newUser);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                MessageBox.Show("New user successfully saved", "Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Entrance entrance = new Entrance();
                entrance.Show();
                this.Close();

            }
        }

        private string HashPass(string password)
        {
            var hash = SHA256.Create();
            byte[] inputBytes = Encoding.UTF8.GetBytes(password);
            byte[] hashBytes = hash.ComputeHash(inputBytes);
            return Convert.ToBase64String(hashBytes).Replace("-", "");


        }

        bool isPasswordVisible = true;
        bool isPasswordVisible1 = true;
        private void btnPasswordNoShow_Click(object sender, EventArgs e)
        {
            isPasswordVisible = !isPasswordVisible;
            txtPassword.PasswordChar = isPasswordVisible ? '\0' : '*';
            btnPasswordNoShow.IconChar = isPasswordVisible ? IconChar.EyeSlash : IconChar.Eye;
        }

        private void btnReptPsswordShow_Click(object sender, EventArgs e)
        {
            isPasswordVisible1 = !isPasswordVisible1;
            txtRepeatPassword.PasswordChar = isPasswordVisible1 ? '\0' : '*';
            btnReptPsswordShow.IconChar = isPasswordVisible1 ? IconChar.EyeSlash : IconChar.Eye;
        }

        //Şifre kuralları
        private void btnWarningIcon_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The password must contain at least one uppercase letter, one lowercase letter, one number, one special character, and at least 8 characters.", "Password Rules", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
