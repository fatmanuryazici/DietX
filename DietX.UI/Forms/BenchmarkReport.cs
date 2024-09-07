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
    public partial class BenchmarkReport : Form
    {
        public BenchmarkReport()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Reports reports = new Reports();
            reports.Show();
            this.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
