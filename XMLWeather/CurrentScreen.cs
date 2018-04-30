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

        public void DisplayCurrent()
        {
            cityOutput.Text = Form1.days[0].location;
            //tempOutput.Text = Form1.days[0].currentTemp + "°C";
            minOutput.Text = Form1.days[0].tempLow + "°C" + " / " + Form1.days[0].tempHigh + "°C";
            //windLabel.Text = Form1.days[0].windDirection + " and " + Form1.days[0].windSpeed;


            if (Form1.days[0].condition.Contains("clear"))
            {
                //pictureBox1 = new PictureBox();
                pictureBox1.Image = Properties.Resources.sunPng;
                //pictureBox1.Refresh();
            }
        }

        private void forecastLabel_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            ForecastScreen fs = new ForecastScreen();
            f.Controls.Add(fs);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}