using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace areaCalculation
{
    public partial class Form1 : Form
    {
        const double inchTocm = 2.54;
        double s, k=1;

        public Form1()
        {
            InitializeComponent();
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            groupBox1.Visible = true;

            if (comboBox1.Text=="三角形")
            {
                triBox.Visible = true;
                circleBox.Visible = false;
                squareBox.Visible = false;
                recBox.Visible = false;
            }
            if (comboBox1.Text == "圆形")
            {
                triBox.Visible = false;
                circleBox.Visible = true;
                squareBox.Visible = false;
                recBox.Visible = false;
            }
            if (comboBox1.Text == "正方形")
            {
                triBox.Visible = false;
                circleBox.Visible = false;
                squareBox.Visible = true;
                recBox.Visible = false;
            }
            if (comboBox1.Text == "矩形")
            {
                triBox.Visible = false;
                circleBox.Visible = false;
                squareBox.Visible = false;
                recBox.Visible = true;
            }
        }

        private void radioButtoncm_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtoncm.Checked)
            {
                k = 1;
            }
            if (radioButtonin.Checked)
            {
                k = inchTocm * inchTocm;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AreaCalculate cal = new AreaCalculate();
            if (comboBox1.Text == "三角形")
            {
                try
                {
                    s = cal.Triangle(Convert.ToDouble(triLength.Text), Convert.ToDouble(triHeight.Text));
                    s = s * k;
                    area.Text = s.ToString("0.000");
                }
                catch (FormatException)
                {
                    MessageBox.Show("请输入正确的数据", "ERROR");
                    triLength.Clear();
                    triHeight.Clear();
                    area.Clear();
                }
            }
            if (comboBox1.Text == "圆形")
            {
                try
                {
                    s = cal.Circle(Convert.ToDouble(diameter.Text));
                    s = s * k;
                    area.Text = s.ToString("0.000");
                }
                catch (FormatException)
                {
                    MessageBox.Show("请输入正确的数据", "ERROR");
                    diameter.Clear();
                    area.Clear();
                }
            }
            if (comboBox1.Text == "正方形")
            {
                try
                {
                    s = cal.Square(Convert.ToDouble(square.Text));
                    s = s * k;
                    area.Text = s.ToString("0.000");
                }
                catch (FormatException)
                {
                    MessageBox.Show("请输入正确的数据", "ERROR");
                    square.Clear();
                    area.Clear();
                }
            }
            if (comboBox1.Text == "矩形")
            {
                try
                {
                    s = cal.Rec(Convert.ToDouble(recLength.Text), Convert.ToDouble(recWide.Text));
                    s = s * k;
                    area.Text = s.ToString("0.000");
                }
                catch (FormatException)
                {
                    MessageBox.Show("请输入正确的数据", "ERROR");
                    recLength.Clear();
                    recWide.Clear();
                    area.Clear();
                }
            }
        }
    }
}