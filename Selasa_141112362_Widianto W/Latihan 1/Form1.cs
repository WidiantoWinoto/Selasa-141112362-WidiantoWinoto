using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Latihan_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            DateTime minimum = new DateTime(DateTime.Now.Year, 1, 1);
            DateTime maximum = new DateTime(DateTime.Now.Year, 12, 31);
            if (vScrollBar2.Value > vScrollBar1.Value)
            {
                vScrollBar2.Value = vScrollBar1.Value;
            }
            minimum = minimum.AddYears(vScrollBar2.Value - vScrollBar2.Maximum);
            maximum = maximum.AddYears(vScrollBar1.Value - vScrollBar1.Maximum);
            dateTimePicker1.MinDate = minimum;
            dateTimePicker1.MaxDate = maximum;
            label6.Text = vScrollBar1.Value.ToString();
            label7.Text = vScrollBar2.Value.ToString();
        }

        private void vScrollBar2_Scroll(object sender, ScrollEventArgs e)
        {
            DateTime Min = new DateTime(DateTime.Now.Year, 1, 1);
            DateTime Max = new DateTime(DateTime.Now.Year, 12, 31);
            if (vScrollBar2.Value > vScrollBar1.Value)
            {
                vScrollBar1.Value = vScrollBar2.Value;
            }
            Min = Min.AddYears(vScrollBar2.Value - vScrollBar2.Maximum);
            Max = Max.AddYears(vScrollBar1.Value - vScrollBar1.Maximum);
            dateTimePicker1.MaxDate = Max;
            dateTimePicker1.MinDate = Min;
            label6.Text = vScrollBar1.Value.ToString();
            label7.Text = vScrollBar2.Value.ToString();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

    }
}
