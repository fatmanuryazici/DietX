using DietX.BLL.UserBusinessService;
using DietX.Entities.Entities.UserEntities;
using DietX.Entities.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DietX.UI.Forms
{
    public partial class Menu : Form
    {
        private readonly IUserService _userService;
        public Menu()
        {
            
            InitializeComponent();
            _userService = new UserService();
            double index;
          
            if (UserManager.CurrentUser != null)
            {
                lbl_User.Text = $"{UserManager.CurrentUser.FirstName} {UserManager.CurrentUser.LastName}";
                lbl_Height.Text = $"{UserManager.CurrentUser.Height} cm";
                lbl_Weight.Text = $"{UserManager.CurrentUser.Weight} kg";

                if (UserManager.CurrentUser.Gender == Gender.Male)
                {
                    index = _userService.CalculateBMIMale(UserManager.CurrentUser.Weight, UserManager.CurrentUser.Height);

                }
                else if (UserManager.CurrentUser.Gender == Gender.Female)
                {
                    index = _userService.CalculateBMIFemale(UserManager.CurrentUser.Weight, UserManager.CurrentUser.Height);
                }
                else
                {
                    lbl_BMI.Text = "Please specify gender for accurate BMI calculation.";
                    return;
                }

                // Display the calculated BMI
                lbl_BMI.Text = $"{index.ToString("0.0")}";

                //Body mass index control according to fixed ranges
                if (index < 18.5)
                {
                    lbl_status.Text = "Weight Status: You are underweight";
                }
                else if (index < 24.9)
                {
                    lbl_status.Text = "Weight Status: You are at a normal weight";
                }
                else if (index < 29.9)
                {
                    lbl_status.Text = "Weight Status: You are overweight";
                }
                else if (index < 34.9)
                {
                    lbl_status.Text = "Weight Status: You are obese";
                }
                else if (index < 39.9)
                {
                    lbl_status.Text = "Weight Status: You are severely obese";
                }
                else
                {
                    lbl_status.Text = " Weight Status: You are morbidly obese";
                }

            }
            else
            {
                // Kullanıcı bilgisi bulunamazsa, giriş ekranına yönlendir
                MessageBox.Show("User info is not found. Please enter again.");
                this.Close();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AddFood addFood = new AddFood();
            addFood.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UserInformation userInformation = new UserInformation();
            userInformation.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Reports reports = new Reports();
            reports.Show();
            this.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            AddMeal addMeal = new AddMeal();
            addMeal.Show();
            this.Close();
        }

       
    }
}
