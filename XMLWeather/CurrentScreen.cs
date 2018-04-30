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
    public partial class CurrentScreen : UserControl
    {
        public CurrentScreen()
        {
            InitializeComponent();
            DisplayCurrent();
        }

        //what is displayed on current screen
        public void DisplayCurrent()
        { 
            cityOutput.Text = Form1.days[0].location;
            //tempOutput.Text = Form1.days[0].currentTemp + "°C";
            maxOutput.Text = Form1.days[0].tempLow + "°C" + " / " + Form1.days[0].tempHigh + "°C";
            minOutput.Text = Form1.days[0].tempHigh + "°C" + " / " + Form1.days[0].tempLow + "°C";
            windLabel.Text = Form1.days[0].windDirection + " and " + Form1.days[0].windSpeed;

            //Todays weather
            if (Form1.days[0].condition.Contains("clear"))
            {
                //pictureBox1 = new PictureBox();
                pictureBox1.BackgroundImage = Properties.Resources.sunPng;
                //pictureBox1.Refresh();
            }

            if (Form1.days[0].condition.Contains("clouds"))
            {
                //pictureBox1 = new PictureBox();
                pictureBox1.BackgroundImage = Properties.Resources.cloudPng;
                //pictureBox1.Refresh();
            }

            if (Form1.days[0].condition.Contains("rain"))
            {
                //pictureBox1 = new PictureBox();
                pictureBox1.BackgroundImage = Properties.Resources.rainPng;
                //pictureBox1.Refresh();
            }

            if (Form1.days[0].condition.Contains("intense rain"))
            {
                //pictureBox1 = new PictureBox();
                pictureBox1.BackgroundImage = Properties.Resources.thunderPng;
                //pictureBox1.Refresh();
            }
        }

        //go to forecast screen
        private void forecastLabel_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            ForecastScreen fs = new ForecastScreen();
            f.Controls.Add(fs);
        }

        //exit application
        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}