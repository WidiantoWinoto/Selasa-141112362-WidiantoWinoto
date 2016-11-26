using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VolleyBall_Problem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnHitung_Click(object sender, EventArgs e)
        {
            double ScoreA, ScoreB, Scorec1 = 1, Scorec2 = 1, Scorec3 = 1, result = 0, i, j, k, n;
            ScoreA = Convert.ToInt64(Txt1.Text);
            ScoreB = Convert.ToInt64(Txt2.Text);

            if ((ScoreA == 25 && ScoreB < 24) || (ScoreB == 25 && ScoreA < 24))
            {
                if (ScoreA < ScoreB)
                {
                    n = ScoreA;
                }
                else
                {
                    n = ScoreB;
                }
                for (i = (24 + n); i > 0; i--)
                {
                    Scorec1 *= i;
                }
                for (j = ((24 + n) - n); j > 0; j--)
                {
                    Scorec2 *= j;
                }
                for (k = n; k > 0; k--)
                {
                    Scorec3 *= k;
                }
                result = Scorec1 / (Scorec2 * Scorec3);
                TxtHasil.Text = Convert.ToString(result);
            }
            else if (ScoreA < 0 || ScoreB < 0 || Math.Abs(ScoreA - ScoreB) > 1)
            {
                result = 0;
                TxtHasil.Text = Convert.ToString(result);
            }
            else if (ScoreA == 24 && ScoreB == 24)
            {
                MessageBox.Show("JUICE!!!");
                MessageBox.Show("Lanjut Main.");
            }
            else
            {
                MessageBox.Show("Lanjut Main.");
            }
            if (TxtHasil.Text == "0")
            {
                if (ScoreA > ScoreB)
                {
                    MessageBox.Show("Pemenangnya adalah Tim A");
                }
                else
                {
                    MessageBox.Show("Pemenangnya adalah Tim B");
                }
            }
            else if (result > 1000000007)
            {
                result %= 1000000007;
                TxtHasil.Text = Convert.ToString(result);
            }
        }
    }
}
