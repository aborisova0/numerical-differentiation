using System;
using System.Drawing;
using System.Windows.Forms;

namespace Курсовая
{
    public partial class Form1 : Form 
    {
        public Form1()
        {
            InitializeComponent();
        }
        public double f(double x) //возвращает значение функции f(x) 
        {
            return 2 * Math.Pow(x, 2) + 10 * x * Math.Sin(x);             
        }

        public double f1d(double x, double h) //вычисление 1-ой производной 
        {
            return (f(x + h) - f(x - h)) / (2 * h);
        } 
       
        public double f2d(double x, double h) //вычисление 2-ой производной 
        {
            return (f(x + h) - 2 * f(x) + f(x - h)) / Math.Pow(h, 2);
        }

        public double f3d(double x, double h) //вычисление 3-ой производной 
        {
            return (f(x + 2 * h) - 2 * f(x + h) + 2 * f(x - h) - f(x - 2 * h)) / (2 * Math.Pow(h, 3));
        }

        public double f4d(double x, double h) //вычисление 4-ой производной 
        {
            return (f(x + 2 * h) - 4 * f(x + h) + 6 * f(x) - 4 * f(x - h) + f(x - 2 * h)) / Math.Pow(h, 4);
        }

        public double f1t (double x) //производная 1-го порядка 
        {            
            return 4 * x + 10 * Math.Sin(x) + 10 * x * Math.Cos(x); 
        }

        public double f2t(double x) //производная 2-го порядка
        {
            return -10 * x * Math.Sin(x) + 20 * Math.Cos(x) + 4;
        }

        public double f3t(double x) //производная 3-го порядка
        {
            return -10 * x * Math.Cos(x) - 30 * Math.Sin(x);
        }

        public double f4t(double x) //производная 4-го порядка
        {
            return 10 * x * Math.Sin(x) - 40 * Math.Cos(x);
        }

        public double E1(double x, double h) //погрешность вычисления 1-ой производной
        {
            return Math.Abs((f1d(x, h) - f1t(x)) / f1t(x)); 
        }

        public double E2(double x, double h) //погрешность вычисления 2-ой производной
        {
            return Math.Abs((f2d(x, h) - f2t(x)) / f2t(x));
        }

        public double E3(double x, double h) //погрешность вычисления 3-ой производной
        {
            return Math.Abs((f3d(x, h) - f3t(x)) / f3t(x));
        }

        public double E4(double x, double h) //погрешность вычисления 4-ой производной
        {
            return Math.Abs((f4d(x, h) - f4t(x)) / f4t(x));
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            double a, b;
            a = -20; //интервал на котором задана функция 
            b = 20;

            double xL = a;
            func.Series[0].Points.Clear();
            func.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            do
            {
                func.Series[0].Points.AddXY(xL, f(xL));
                xL += 0.1;
            }
            while ((int)xL != (int)b);
            func.Series[0].Color = Color.Black;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double a, b;
            a = Convert.ToDouble(left.Text); //интервал на котором задана функция 
            b = Convert.ToDouble(right.Text);       

            if (a > b)            
            {
              double tmp;
              tmp = a;
              a = b;
              b = tmp;
            }

            //рисуем графики погрешностей 
            double xL = a;
            chart1.Series[0].Points.Clear();
            chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;

            chart2.Series[0].Points.Clear();
            chart2.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;

            chart3.Series[0].Points.Clear();
            chart3.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;

            chart4.Series[0].Points.Clear();
            chart4.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;

            do
            {
                chart1.Series[0].Points.AddXY(xL, E1(2, xL));
                chart2.Series[0].Points.AddXY(xL, E2(2, xL));
                chart3.Series[0].Points.AddXY(xL, E3(2, xL));
                chart4.Series[0].Points.AddXY(xL, E4(2, xL));
                xL += 0.1;
            }

            while ((int)xL != (int)b);

            chart1.ChartAreas[0].AxisY.Maximum = 2;
            chart2.ChartAreas[0].AxisY.Maximum = 2;
            chart3.ChartAreas[0].AxisY.Maximum = 2;
            chart4.ChartAreas[0].AxisY.Maximum = 2;

            chart1.Series[0].Color = Color.Red;
            chart2.Series[0].Color = Color.Red;
            chart3.Series[0].Color = Color.Red;
            chart4.Series[0].Color = Color.Red;
        }              
    }
}

   
