﻿using System;
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
    public partial class Reports : Form
    {
        public Reports()
        {
            InitializeComponent();
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

        private void button2_Click(object sender, EventArgs e)
        {
            DailyRaport dailyraport = new DailyRaport();
            dailyraport.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            BenchmarkReport benchmarkReport = new BenchmarkReport();
            benchmarkReport.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MealReport mealReport = new MealReport();
            mealReport.Show();
            this.Close();
        }
    }
}
