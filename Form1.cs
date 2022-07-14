using LiveCharts;
using LiveCharts.Configurations;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;

namespace FuntionGraph
{
    public partial class Form1 : Form
    {
        //List<int> x = new List<int>();
        string funtioo;

        public Form1()
        {
            
            InitializeComponent();
            var values = new ChartValues<Point>();
            var values2 = new ChartValues<Point>();
            // Create sine graph
            
            
            graphDraw(funtion(),"s");

        }

        private void graphDraw(ChartValues<Point> values, string name)
        {
            cartesianChart1.Series.Add(new LineSeries
            {
                Configuration = new CartesianMapper<Point>()
                .X(point => point.X) // Define a function that returns a value that should map to the x-axis
                .Y(point => point.Y), // Define a function that returns a value that should map to the y-axis
                Title = name,
                Values = values,
                //Stroke = System.Windows.Media.Brushes.Red,
                PointGeometry = null
            });

        }

        private ChartValues<Point> funtion()
        {
            var values = new ChartValues<Point>();
            for (double n = -10; n < 10; n++)
            {
                var point = new Point() { X = (int)n, Y = (int)(n * n) };
                values.Add(point);
            }
            return values;
        }

        private void btn_add_funtion_Click(object sender, EventArgs e)
        {
            funtioo = tb_funtion.Text;
            tb_funtion.Focus();
        }
    }

   
}
