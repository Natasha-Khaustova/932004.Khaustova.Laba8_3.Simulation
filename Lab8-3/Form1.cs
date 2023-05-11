using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab8_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double Value1 ;
        double Value2 ;
        double Value3 ;
        double Value4 ;
        double Value5 ;
        int n ;
        private void button1_Click(object sender, EventArgs e)
        {
            foreach (var series in chart1.Series)
            {
                series.Points.Clear();
            }
            Value1 = (double)Val1Ed1.Value;
            Value2 = (double)Val1Ed2.Value;
            Value3 = (double)Val1Ed3.Value;
            Value4 = (double)Val1Ed4.Value;
            double s = Value1 + Value2 + Value3 + Value4;
            if (s > 1) 
            {
                MessageBox.Show("!FAIL! the sum of the probabilities must be equal to 1");
            }
            else
            {
                Value5 = 1 - s;
            }
            Val1Ed5.Value = (decimal)Value5;
            n = (int)numEd.Value;
            

            double[] Probabilities = { Value1, Value2, Value3, Value4, Value5 };
            double[] Generation = new double[5];

            Random rnd = new Random();
            double randNum;
            for (int i = 0; i < n; i++)
            {
                randNum = rnd.NextDouble();
                int event_id = 0;
                randNum -= Probabilities[0];
                while (randNum > 0)
                {
                    event_id++;
                    randNum -= Probabilities[event_id];
                };
                Generation[event_id]++;
            }

            for (int j = 0; j < 5; j++)
            {
                Generation[j] /= n;
                chart1.Series[j].Points.AddXY(j,Generation[j]);

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            if (n == 0)
                timer1.Stop();
            else
                n--;
        }
    }
}
