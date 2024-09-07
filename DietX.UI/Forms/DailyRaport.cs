using DietX.Entities.Entities.UserEntities;
using DietX.Entities.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DietX.BLL.UserMealReportBusinessService;

namespace DietX.UI.Forms
{
    public partial class DailyRaport : Form
    {
        private readonly IUserMealReportService _userMealService;
        public DailyRaport()
        {
            InitializeComponent();
            _userMealService = new UserMealReportService();
            dtp_Date.Value = DateTime.Now;
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


        private void dtp_Date_ValueChanged(object sender, EventArgs e)
        {
            DateTime seletedDate = dtp_Date.Value.Date;

            //Get user meal reports based on selected date
            List<UserMealReport> entriesForDate = _userMealService.GettAll().Where(x => x.UserId == UserManager.CurrentUser.Id).ToList();
            //List<UserMealReport> entriesForDate = _userMealService.GettAll().Where(x => x.ConsumedDate == seletedDate && x.UserId == UserManager.CurrentUser.Id).ToList();


            //TOTAL ( FULL MEALS)
            //Total Daily Calorie Calculation (Seleted date)
            double totalCalories = entriesForDate.Sum(x => x.TotalCalories);
            lbl_TotalCal.Text =$"{totalCalories.ToString("0.0")} kcal";

            //Total Daily Protein Calculation (Seleted date)
            double totalProtein = entriesForDate.Sum(x => x.TotalProtein);
            lbl_TotalProtein.Text =$"{totalProtein.ToString("0.0")} gr";

            //Total Daily Fat Calculation (Seleted date)
            double totalFat = entriesForDate.Sum(x => x.TotalFat);
            lbl_TotalFat.Text =$"{totalFat.ToString("0.0")} gr";
            //Total Daily Carbohydrate Calculation (Seleted date)
            double totalCarb = entriesForDate.Sum(x => x.TotalCarbs);
            lbl_TotalCarb.Text =$"{totalCarb.ToString("0.0")} gr";



            // BREAKFAST NUTRİENT ANALYSİS (Seleted date)

            // Total Calorie Calculation 
            double breakfastCalories = entriesForDate.Where(x => x.MealId == 1).Sum(x =>x.TotalCalories);
            lblBrkfastCal.Text = $"{breakfastCalories.ToString("0.0")} kcal";

            // Total Protein Calculation
            double breakfastProtein = entriesForDate.Where(x => x.MealId == 1).Sum(x => x.TotalProtein);
            lblBrkfastPro.Text = $"{breakfastProtein.ToString("0.0")} gr";

            // Total Yağ Calculation
            double breakfastFat = entriesForDate.Where(x => x.MealId == 1).Sum(x =>x.TotalFat);
            lblBrkfastFat.Text = $"{breakfastFat.ToString("0.0")} gr";

            // Total Carbohydrate Calculation
            double breakfastCarbs = entriesForDate.Where(x => x.MealId == 1).Sum(x => x.TotalCarbs);
            lblDinnerCarb.Text = $"{breakfastCarbs.ToString("0.0")} gr";





            //LUNCH NUTRİENT ANALYSİS (Seleted date)

            // Total Calorie Calculation 
            double lunchCalories = entriesForDate.Where(x => x.MealId == 2).Sum(x => x.TotalCalories);
            lblLunchCal.Text = $"{lunchCalories.ToString("0.0")} kcal";

            // Total Protein Calculation
            double lunchProtein = entriesForDate.Where(x => x.MealId == 2).Sum(x => x.TotalProtein);
            lblLunchPro.Text = $"{lunchProtein.ToString("0.0")} gr";

            // Total Yağ Calculation
            double lunchFat = entriesForDate.Where(x => x.MealId == 2).Sum(x => x.TotalFat);
            lblLunchFat.Text = $"{lunchFat.ToString("0.0")} gr";

            // Total Carbohydrate Calculation
            double lunchCarb = entriesForDate.Where(x => x.MealId == 2).Sum(x => x.TotalCarbs);
            lblLunchCarb.Text = $"{lunchCarb.ToString("0.0")} gr";





            // DINNER NUTRİENT ANALYSİS (Seleted date)

            // Total Calorie Calculation
            double dinnerCalories = entriesForDate.Where(x => x.MealId == 3).Sum(x => x.TotalCalories);
            lblDinnerCal.Text = $"{dinnerCalories.ToString("0.0")} kcal";

            // Total Protein Calculation
            double dinnerProtein = entriesForDate.Where(x => x.MealId == 3).Sum(x => x.TotalProtein);
            lblDinnerPro.Text = $"{dinnerProtein.ToString("0.0")} gr";


            // Total Yağ Calculation
            double dinnerFat = entriesForDate.Where(x => x.MealId == 3).Sum(x => x.TotalFat);
            lblDinnerFat.Text = $"{dinnerFat.ToString("0.0")} gr";

            // Total Carbohydrate Calculation
            double dinnerCarb = entriesForDate.Where(x => x.MealId == 3).Sum(x => x.TotalCarbs);
            lblDinnerCarb.Text = $"{dinnerCarb.ToString("0.0")} gr";






            // SNACK NUTRİENT ANALYSİS (Seleted date)

            // Total Calorie Calculation
            double snackCalories = entriesForDate.Where(x => x.MealId == 4).Sum(x => x.TotalCalories);
            lblSnackCal.Text = $"{snackCalories.ToString("0.0")} kcal";

            // Total Protein Calculation
            double snackProtein = entriesForDate.Where(x => x.MealId == 4).Sum(x => x.TotalProtein);
            lblSnackPro.Text = $"{snackProtein.ToString("0.0")} gr";

            // Total Yağ Calculation
            double snackFat = entriesForDate.Where(x => x.MealId == 4).Sum(x => x.TotalFat);
            lblSnackFat.Text = $"{snackFat.ToString("0.0")} gr";

            // Total Carbohydrate Calculation
            double snackCarb = entriesForDate.Where(x => x.MealId == 4).Sum(x => x.TotalCarbs);
            lblSnackCarb.Text = $"{snackCarb.ToString("0.0")} gr";
        }
       
    }
}
