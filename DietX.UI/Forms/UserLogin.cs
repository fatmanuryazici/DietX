using DietX.BLL.UserBusinessService;
using DietX.Entities.Entities.UserEntities;
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
    public partial class UserLogin : Form
    {
        private readonly IUserService _userService = new UserService();
        public UserLogin()
        {
            InitializeComponent();
            
        }      

        private void button1_Click(object sender, EventArgs e)
        {
            Entrance entrance = new Entrance();
            entrance.Show();
            this.Close();
        }

        private void button_woc1_Click(object sender, EventArgs e)
        {
            var email = txt_Email.Text;
            var password = txt_Password.Text;


            User loggedInUser = _userService.GetUserByEmail(email);
            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter your email and password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var user = _userService.Login(email, password);
            if (user == null)
            {
                MessageBox.Show("Invalid username or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            UserManager.CurrentUser = loggedInUser;
            MessageBox.Show("User validated. Welcome!", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Menu menu = new Menu();
            menu.Show();
            this.Close();
        }
    }
}
