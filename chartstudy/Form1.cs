using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chartstudy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            chart1.Series[0].ChartType =
               System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            //chart1.Series["Series2"].ChartType =
            // System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            chart1.Series[0].Points.Add(180);
            chart1.Series[0].Points.Add(170);
            chart1.Series[0].Points.Add(175);
            chart1.Series[0].Points.Add(190);
            chart1.Series[0].Points.Add(168);

            chart1.Series.Add("series2");
            chart1.Series[1].Points.Add(110);
            chart1.Series[1].Points.Add(150);
            chart1.Series[1].Points.Add(135);
            chart1.Series[1].Points.Add(110);
            chart1.Series[1].Points.Add(128);

            chart1.Series.Add("내꺼");
            chart1.Series[2].Points.Add(20);
            chart1.Series[2].Points.Add(30);
            chart1.Series[2].Points.Add(35);
            chart1.Series[2].Points.Add(50);
            chart1.Series[2].Points.Add(78);

            //chart1.Series[1].ChartType =
            //   System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            chart1.Series[0].Points.Clear();
            chart1.Series[0].Points.AddXY("홍길동", 180);
            chart1.Series[0].Points.AddXY("변강쇠", 170);
            chart1.Series[0].Points.AddXY("김철수", 175);
            chart1.Series[0].Points.AddXY("박개똥", 190);
            chart1.Series[0].Points.AddXY("이칠푼", 168);
            chart1.Series[0].Color = Color.Red;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            chart1.Series[2].Points.Clear();
            chart1.Series[2].Points.AddXY("홍길동", 180);
            chart1.Series[2].Points.AddXY("변강쇠", 170);
            chart1.Series[2].Points.AddXY("김철수", 175);
            chart1.Series[2].Points.AddXY("박개똥", 190);
            chart1.Series[2].Points.AddXY("이칠푼", 168);
            chart1.Series[2].Points[0].Color = Color.Red;
            chart1.Series[2].Points[0].Label = "180";
            chart1.Series[2].Points[1].Color = Color.Green;
            chart1.Series[2].Points[1].Label = "170";
            chart1.Series[2].Points[2].Color = Color.Blue;
            chart1.Series[2].Points[2].Label = "175";
            chart1.Series[2].Points[3].Color = Color.Orange;
            chart1.Series[2].Points[3].Label = "190";
            chart1.Series[2].Points[4].Color = Color.Purple;
            chart1.Series[2].Points[4].Label = "168";
            //chart1.Titles[2].Text = "Height of 5 Men";
        }
    }
}
