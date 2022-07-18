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
using org.mariuszgromada.math.mxparser;

namespace FuntionGraph
{
    public partial class Form1 : Form
    {
        //List<int> x = new List<int>();
        string funtionMath;

        public Form1()
        {
            
            InitializeComponent();
               
          //graphDraw(funtion(),"s");

        }

        private void graphDraw(ChartValues<PointDouble> values, string name)
        {
            //cartesianChart1.
            cartesianChart1.Series.Add(new LineSeries
            {
                Configuration = new CartesianMapper<PointDouble>()
                .X(point => point.X) // Define a function that returns a value that should map to the x-axis
                .Y(point => point.Y), // Define a function that returns a value that should map to the y-axis
                Title = name,
                Values = values,
                //Stroke = System.Windows.Media.Brushes.Red, 
                PointGeometry = null,
                //LineSmoothness = 1


            });

        }

        private ChartValues<PointDouble> CreateChartValues(List<double> x, List<double> y)
        {
            var values = new ChartValues<PointDouble>();
            for (int n = 0; n < x.Count; n++)
            {
                var point = new PointDouble() { X = x.ElementAt(n), Y = y.ElementAt(n) };
                values.Add(point);
            }
            return values;
        }

        private void btn_add_funtion_Click(object sender, EventArgs e)
        {
            funtionMath = tb_funtion.Text;
            tb_funtion.Focus();
            list_funtions.Items.Add(funtionMath);
            analiseFuntion(funtionMath);
        }

        private void analiseFuntion(string funtion)
        {
            List<double> ListX = new List<double>();

            List<double> ListY = new List<double>();
            for (double a = -100; a < +100; a++)
            {
               
                string x_str = "x = " + a.ToString() + "/ 10";
                Argument x = new Argument(x_str);
                Argument y = new Argument(funtion, x);
                Expression e = new Expression("y", y);
                ListX.Add(a);
                ListY.Add(e.calculate());
            }
            graphDraw(CreateChartValues(ListX, ListY), funtionMath);
            //Argument x = new Argument("x = 5");
            //Argument y = new Argument(funtion, x);
            //Expression e = new Expression("y", y);
            //MessageBox.Show(e.calculate().ToString());

        }


        private struct PointDouble
        {
            public double X;
            public double Y;
            
        }

        private void remove_all_Click(object sender, EventArgs e)
        {
            cartesianChart1.Series.Clear();
            list_funtions.Items.Clear();
        }

        private void remove_selet_Click(object sender, EventArgs e)
        {
            //
        }
    }

 
}
