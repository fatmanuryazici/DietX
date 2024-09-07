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
    public partial class AddFood : Form
    {
        public AddFood()
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

        //private void button_woc3_Click(object sender, EventArgs e)
        //{
        //    pcbox_addFood.SizeMode = PictureBoxSizeMode.StretchImage;
        //    OpenFileDialog openFileDialog = new OpenFileDialog();
        //    openFileDialog.ShowDialog();
        //    pcbox_addFood.ImageLocation = openFileDialog.FileName;
        //}

       
        


        private void button_woc3_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog()
            {
                Filter = "Image files(*.jpg;*.jpegİ*.png)|*.jpg;*.jpeg;*.png",
                Multiselect = false
            };
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                //Display Image To Picturebox
                pcbox_addFood.Image = Image.FromFile(ofd.FileName);              

            }
        }

       
    }
}
