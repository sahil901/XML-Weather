using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Xml;

namespace XMLWeather
{
    public partial class Form1 : Form
    {
        // TODO: create list to hold day objects
        public static List<Day> days = new List<Day>();
        Day d = new Day();

        public Form1()
        {
            InitializeComponent();
            GetData();
            ExtractCurrent();
            ExtractForecast();

            // open weather screen for todays weather
            CurrentScreen cs = new CurrentScreen();
            this.Controls.Add(cs);
        }

        //api information
        private static void GetData()
        {
            WebClient client = new WebClient();

            // one day forecast
            client.DownloadFile("http://api.openweathermap.org/data/2.5/weather?q=Stratford,CA&mode=xml&units=metric&appid=3f2e224b815c0ed45524322e145149f0", "WeatherData.xml");
            // mulit day forecast
            client.DownloadFile("http://api.openweathermap.org/data/2.5/forecast/daily?q=Stratford,CA&mode=xml&units=metric&cnt=7&appid=3f2e224b815c0ed45524322e145149f0", "WeatherData7Day.xml");
        }

        //current date weather forecast
        private void ExtractCurrent()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("WeatherData.xml");

            XmlNode city = doc.SelectSingleNode("current/city");
            XmlNode temperature = doc.SelectSingleNode("current/temperature");
            XmlNode windSpeed = doc.SelectSingleNode("current/wind/speed");
            XmlNode windDirection = doc.SelectSingleNode("current/wind/direction");
            XmlNode precipitation = doc.SelectSingleNode("current/precipitation");
            XmlNode condition = doc.SelectSingleNode("current/weather");

            Day d = new Day();

            d.location = city.Attributes["name"].Value;
            d.currentTemp = temperature.Attributes["value"].Value;
            d.tempHigh = temperature.Attributes["max"].Value;
            d.tempLow = temperature.Attributes["min"].Value;
            d.windSpeed = windSpeed.Attributes["name"].Value;
            d.windDirection = windDirection.Attributes["name"].Value;
            d.condition = condition.Attributes["value"].Value;

            days.Add(d);

        }

        //3 day weather forecast
        private void ExtractForecast()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("WeatherData7Day.xml");

            XmlNodeList dateList = doc.GetElementsByTagName("time");
            XmlNodeList tempList = doc.GetElementsByTagName("temperature");
            XmlNodeList tempmaxList = doc.GetElementsByTagName("temperature");
            XmlNodeList tempminList = doc.GetElementsByTagName("temperature");
            XmlNodeList cloudsList = doc.GetElementsByTagName("clouds");

            for (int i = 1; i < tempList.Count; i++)
            {
                Day d = new Day();
                d.date = dateList[i].Attributes["day"].Value;
                d.currentTemp = tempList[i].Attributes["day"].Value;
                d.tempHigh = tempmaxList[i].Attributes["max"].Value;
                d.tempLow = tempminList[i].Attributes["min"].Value;
                d.condition = cloudsList[i].Attributes["value"].Value;

                days.Add(d);
            }
        }
    }
}