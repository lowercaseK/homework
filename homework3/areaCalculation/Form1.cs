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

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            double s = 0;
            if (comboBox1.Text == "三角形")
            {
                try
                {
                    s = 0.5 * (Convert.ToDouble(triLength.Text) * Convert.ToDouble(triHeight.Text));
                }
                catch(FormatException)
                {
                    MessageBox.Show("请输入正确的数据", "ERROR");
                    triLength.Clear();
                    triHeight.Clear();
                }

                /*s = 0.5 * (Convert.ToDouble(triLength.Text) * Convert.ToDouble(triHeight.Text));
                if (comboBox2.Text == "英寸(inch)")
                {
                    s = s * 2.54 * 2.54;
                }*/
            }
            if (comboBox1.Text == "圆形")
            {
                s = 3.1415 * (Convert.ToDouble(diameter.Text) * Convert.ToDouble(diameter.Text)) / 4;
                if (comboBox2.Text == "英寸(inch)")
                {
                    s = s * 2.54 * 2.54;
                }
            }
            if (comboBox1.Text == "正方形")
            {
                s = (Convert.ToDouble(square.Text) * Convert.ToDouble(square.Text));
                if (comboBox2.Text == "英寸(inch)")
                {
                    s = s * 2.54 * 2.54;
                }
            }
            if (comboBox1.Text == "矩形")
            {
                s = (Convert.ToDouble(recLength.Text) * Convert.ToDouble(recWide.Text));
                if (comboBox2.Text == "英寸(inch)")
                {
                    s = s * 2.54 * 2.54;
                }
            }
            area.Text = s.ToString("0.000");
        }

    }
}
