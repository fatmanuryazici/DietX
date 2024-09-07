using AutoMapper;
using DietX.BLL.CategoryBusinessService;
using DietX.BLL.FoodBusinessService;
using DietX.BLL.MealBusinessService;
using DietX.BLL.UserMealReportBusinessService;
using DietX.Entities.Entities;
using DietX.Entities.Entities.UserEntities;
using DietX.UI.Vms;
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
    public partial class AddMeal : Form
    {
        private readonly IFoodService _foodService;
        private readonly ICategoryService _categoryService;
        private readonly IMealService _mealService;
        private readonly IUserMealReportService userMealReportService;
        private readonly IMapper _mapper;
        public AddMeal()
        {
            InitializeComponent();
            var config = new MapperConfiguration(
                cfg =>
                {
                    cfg.AddProfile<ModelProfiler>();
                });
            _mapper = config.CreateMapper();
            userMealReportService= new UserMealReportService();

            _mealService = new MealService();
            _categoryService = new CategoryService();
            _foodService = new FoodService();

            GetAllMeal();
            GetAllCategory();
            GetAllFood();
            GetAllReport();

        }

        private void GetAllMeal()
        {
            cb_Meal.DataSource = _mealService.GettAll();
            cb_Meal.DisplayMember ="Name";
            cb_Meal.ValueMember="Id";
        }

        private void GetAllCategory()
        {
            cb_Categories.DataSource = _categoryService.GettAll();
            cb_Categories.DisplayMember = "Name";
            cb_Categories.ValueMember="Id";
        }

        private void GetAllFood()
        {
            Category seletedcategory = (Category)cb_Categories.SelectedItem;
            cb_Food.DataSource = _foodService.GettAll().Where(x => x.CategoryId == seletedcategory.Id).ToList();
            cb_Food.DisplayMember = "Name";
            cb_Food.ValueMember="Id";
        }

        private void cb_Categories_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetAllFood();
        }


        private void cb_Food_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_Food.SelectedItem != null)
            {
                string fileName = ((Food)cb_Food.SelectedItem).Picture;
                pictureFood.Image = Image.FromFile($"..\\..\\..{fileName}");
            }

            if (cb_Food.SelectedItem != null)
            {
                var fileName = ((Food)cb_Food.SelectedItem).PortionType.ToString();
                var measure = ((Food)cb_Food.SelectedItem).Measure;
                //lbl_PorsionType.Text = $" 1 {fileName} {measure * 100} gr ";
            }
        }
        private void GetAllReport()
        {
            dgw_EatReport.DataSource = null;
            dgw_EatReport.DataSource = _mapper.Map<List<UserMealReportVm>>(userMealReportService.GettAll());
            dgw_EatReport.Columns["Id"].Visible =false;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Add
        private void button_woc2_Click(object sender, EventArgs e)
        {
            Category selectedCategory = (Category)cb_Categories.SelectedItem;

            Food selectedFood = (Food)cb_Food.SelectedItem;
            //Calculation
            var totalMeasure = Convert.ToDouble(num_Measure.Value);
            double totalCalories = selectedFood.Calorie * totalMeasure;
            double totalFat = selectedFood.Fat * totalMeasure;
            double totalProtein = selectedFood.Protein * totalMeasure;
            double totalCarbs = selectedFood.Carbohydrate * totalMeasure;



            UserMealReport userMealReport = new UserMealReport()
            {
                UserId= UserManager.CurrentUser.Id,
                ConsumedDate = date_eat.Value,
                FoodId =(int)cb_Food.SelectedValue,
                CategoryId = (int)cb_Categories.SelectedValue,
                MealId = (int)cb_Meal.SelectedValue,
                TotalMeasure =Convert.ToDouble(num_Measure.Value),
                TotalCalories = totalCalories,
                TotalFat = totalFat,
                TotalProtein = totalProtein,
                TotalCarbs = totalCarbs,


            };
            userMealReportService.Add(userMealReport);
            GetAllReport();
        }

        //Update
        private void button_woc1_Click(object sender, EventArgs e)
        {
            Food selectedFood = (Food)cb_Food.SelectedItem;
            //Calculation
            var totalMeasure = Convert.ToDouble(num_Measure.Value);
            double totalCalories = selectedFood.Calorie * totalMeasure;
            double totalFat = selectedFood.Fat * totalMeasure;
            double totalProtein = selectedFood.Protein * totalMeasure;
            double totalCarbs = selectedFood.Carbohydrate * totalMeasure;

            var newupdateUserMeal = userMealReportService.GetById(UserIdSec());
            newupdateUserMeal.ConsumedDate = date_eat.Value;
            newupdateUserMeal.TotalCalories = totalCalories;
            newupdateUserMeal.TotalCarbs = totalCarbs;
            newupdateUserMeal.TotalProtein = totalProtein;
            newupdateUserMeal.TotalFat = totalFat;
            newupdateUserMeal.TotalMeasure = (double)num_Measure.Value;
            newupdateUserMeal.FoodId = (int)cb_Food.SelectedValue;
            newupdateUserMeal.MealId = (int)cb_Meal.SelectedValue;
            newupdateUserMeal.CategoryId = (int)cb_Categories.SelectedValue;

            userMealReportService.Update(newupdateUserMeal);
            GetAllReport();
        }

        private int UserIdSec()
        {
            return (int)dgw_EatReport.SelectedRows[0].Cells["Id"].Value;
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            userMealReportService.Delete(UserIdSec());
            GetAllReport();
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Food selectedFood = (Food)cb_Food.SelectedItem;
            var totalMeasure = Convert.ToDouble(num_Measure.Value);
            double totalCalories = selectedFood.Calorie * totalMeasure;
            double totalFat = selectedFood.Fat * totalMeasure;
            double totalProtein = selectedFood.Protein * totalMeasure;
            double totalCarbs = selectedFood.Carbohydrate * totalMeasure;

            var newupdate = userMealReportService.GetById(UserIdSec());
            date_eat.Value =newupdate.ConsumedDate;
            totalCalories = newupdate.TotalCalories;
            totalCarbs = newupdate.TotalCarbs;
            totalProtein = newupdate.TotalProtein;
            totalFat= newupdate.TotalFat;
            num_Measure.Value = (int)newupdate.TotalMeasure;
            cb_Food.SelectedValue = newupdate.FoodId;
            cb_Meal.SelectedValue = newupdate.MealId;
            cb_Categories.SelectedValue=newupdate.CategoryId;
        }
    }
}
