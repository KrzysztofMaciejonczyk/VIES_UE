using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace MyApi
{
    public partial class Statistics : Form
    {
        private List<String> cities;
        private List<String> dates;
        public Statistics(List<String> cities, List<string> dates)
        {
            InitializeComponent();
            this.cities = cities;
            this.dates = dates;
        }

        public void populateStats()
        {
            // pie chart for number of companies per city
            var citiesAndTheirCount = cities.GroupBy(x => x).ToDictionary(x => x.Key, y => y.Count());
            // column char for dates of entries in database
            var datesAndTheirCount = dates.GroupBy(x => x).ToDictionary(x => x.Key, y => y.Count());
            foreach (var c in citiesAndTheirCount)
            {
                chartCities.Series["Cities"].Points.AddXY(c.Key, c.Value);
            }
            foreach (var c in datesAndTheirCount)
            {
                chartDates.Series["Dates"].Points.AddXY(c.Key, c.Value);
            }
        }

        private void chartCities_Click(object sender, EventArgs e)
        {

        }

        private void chartDates_Click(object sender, EventArgs e)
        {

        }
    }
}
