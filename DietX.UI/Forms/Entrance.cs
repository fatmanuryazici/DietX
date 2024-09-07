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
    public partial class Entrance : Form
    {
        public Entrance()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserLogin userLogin = new UserLogin();
            userLogin.Show();
            this.Close();
        }
    }
}
