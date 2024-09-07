using DietX.BLL.UserMealReportBusinessService;
using DietX.Entities.Entities;
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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DietX.UI.Forms
{
    public partial class MealReport : Form
    {
        private readonly IUserMealReportService userMeal;
        public MealReport()
        {
            InitializeComponent();
            userMeal = new UserMealReportService();
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

        //Weekly
        private void button_woc2_Click(object sender, EventArgs e)
        {
            int userId = UserManager.CurrentUser.Id;
            List<UserMealReport> userMealReports = userMeal
                .GettAll()
                .Where(u => u.UserId == userId && u.ConsumedDate >= DateTime.Today.AddDays(-7)) // Filter reports for the last 7 days
                .ToList();
            dgw_Report.DataSource = userMealReports; 
        }

        //Monthly
        private void button_woc1_Click(object sender, EventArgs e)
        {
            dgw_Report.DataSource = userMeal.GetMonthlyReport();
        }
    }
}
