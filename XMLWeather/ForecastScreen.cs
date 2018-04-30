using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace XMLWeather
{
    public partial class ForecastScreen : UserControl
    {
        public ForecastScreen()
        {
            InitializeComponent();
            displayForecast();
        }

        //indicating whats on forcast screen
        public void displayForecast()
        {
            date1.Text = Form1.days[1].date;
            min1.Text = Form1.days[1].tempLow;
            max1.Text = Form1.days[1].tempHigh;

            date2.Text = Form1.days[2].date;
            min2.Text = Form1.days[2].tempLow;
            max2.Text = Form1.days[2].tempHigh;

            date3.Text = Form1.days[3].date;
            min3.Text = Form1.days[3].tempLow;
            max3.Text = Form1.days[3].tempHigh;
        }

        //go to current screen
        private void label3_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            CurrentScreen cs = new CurrentScreen();
            f.Controls.Add(cs);
        }

        //display pictures
        private void ForecastScreen_Load(object sender, EventArgs e)
        {
            //Day 1 pictures
            if (Form1.days[1].condition.Contains("clear"))
            {
                //pictureBox3 = new PictureBox();
                pictureBox3.BackgroundImage = Properties.Resources.sunPng;
                //pictureBox3.Refresh();
            }

            if (Form1.days[1].condition.Contains("clouds"))
            {
                //pictureBox3 = new PictureBox();
                pictureBox3.BackgroundImage = Properties.Resources.cloudPng;
                //pictureBox3.Refresh();
            }

            if (Form1.days[1].condition.Contains("rain"))
            {
                //pictureBox3 = new PictureBox();
                pictureBox3.BackgroundImage = Properties.Resources.rainPng;
                //pictureBox3.Refresh();
            }

            if (Form1.days[1].condition.Contains("intense rain"))
            {
                //pictureBox3 = new PictureBox();
                pictureBox3.BackgroundImage = Properties.Resources.thunderPng;
                //pictureBox3.Refresh();
            }

            //Day 2 pictures
            if (Form1.days[2].condition.Contains("clear"))
            {
                //pictureBox2 = new PictureBox();
                pictureBox2.BackgroundImage = Properties.Resources.sunPng;
                //pictureBox2.Refresh();
            }

            if (Form1.days[2].condition.Contains("clouds"))
            {
                //pictureBox2 = new PictureBox();
                pictureBox2.BackgroundImage = Properties.Resources.cloudPng;
                //pictureBox2.Refresh();
            }

            if (Form1.days[2].condition.Contains("rain"))
            {
                //pictureBox2 = new PictureBox();
                pictureBox2.BackgroundImage = Properties.Resources.rainPng;
                //pictureBox2.Refresh();
            }

            if (Form1.days[2].condition.Contains("intense rain"))
            {
                //pictureBox2 = new PictureBox();
                pictureBox2.BackgroundImage = Properties.Resources.thunderPng;
                //pictureBox2.Refresh();
            }

            //Day 3 pictures
            if (Form1.days[3].condition.Contains("clear"))
            {
                //pictureBox1 = new PictureBox();
                pictureBox1.BackgroundImage = Properties.Resources.sunPng;
                //pictureBox1.Refresh();
            }

            if (Form1.days[3].condition.Contains("clouds"))
            {
                //pictureBox1 = new PictureBox();
                pictureBox1.BackgroundImage = Properties.Resources.cloudPng;
                //pictureBox1.Refresh();
            }

            if (Form1.days[3].condition.Contains("rain"))
            {
                //pictureBox1 = new PictureBox();
                pictureBox1.BackgroundImage = Properties.Resources.rainPng;
                //pictureBox1.Refresh();
            }

            if (Form1.days[3].condition.Contains("intense rain"))
            {
                //pictureBox1= new PictureBox();
                pictureBox1.BackgroundImage = Properties.Resources.thunderPng;
                //pictureBox1.Refresh();
            }
        }
    }
}