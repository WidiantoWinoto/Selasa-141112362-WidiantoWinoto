﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Latihan_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            rtb.Font = new Font("Consolas", 12.0f);
            rtb.Height = this.Height;
            rtb.Width = this.Width;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Color warna = new Color();
            PropertyInfo[] p = warna.GetType().GetProperties();
            InstalledFontCollection font = new InstalledFontCollection();

            for (int i = 8; i <= 72; i++)
            {
                tsFontSize.Items.Add(i);
            }

            foreach (FontFamily f in font.Families)
            {
                tsFont.Items.Add(f.Name);
            }

            tsColor.ComboBox.DrawMode = DrawMode.OwnerDrawFixed;

            foreach (PropertyInfo c in p)
            {
                if (c.PropertyType == typeof(System.Drawing.Color))
                {
                    tsColor.Items.Add(c.Name);
                }
            }

            this.tsColor.ComboBox.DrawItem += new DrawItemEventHandler(tsColor_Item);

            tsColor.SelectedIndex = 8;

            tsFontSize.Text = rtb.Font.Size.ToString();
            tsFont.Text = rtb.Font.Name;

            ubahSize();
            ubahFont();
        }
        private void tsColor_Item(object sender, DrawItemEventArgs e)
        {
            if (e.Index >= 0)
            {
                Graphics g = e.Graphics;
                Brush brush = new SolidBrush(e.BackColor);
                Brush tBrush = new SolidBrush(e.ForeColor);

                g.FillRectangle(brush, e.Bounds);
                string s = (string)this.tsColor.Items[e.Index].ToString();
                SolidBrush b = new SolidBrush(Color.FromName(s));
                e.Graphics.DrawRectangle(Pens.Black, 2, e.Bounds.Top + 1, 20, 11);
                e.Graphics.FillRectangle(b, 3, e.Bounds.Top + 2, 19, 10);
                e.Graphics.DrawString(s, this.Font, Brushes.Black, 25, e.Bounds.Top);
                brush.Dispose();
                tBrush.Dispose();
            }
            e.DrawFocusRectangle();
        }
        private void tsBold_Click(object sender, EventArgs e)
        {
            tsBold.Checked = !tsBold.Checked;
            int a = rtb.SelectionStart;
            int b = rtb.SelectionLength + a;

            if (b - a != 0)
            {
                for (int i = a; i < b; i++)
                {
                    rtb.SelectionStart = i;
                    rtb.SelectionLength = 1;
                    rtb.SelectionFont = new Font(rtb.SelectionFont.FontFamily, rtb.SelectionFont.Size, rtb.SelectionFont.Style ^ FontStyle.Bold);
                }
                rtb.SelectionStart = a;
                rtb.SelectionLength = b - a;
            }
            else
            {
                FontStyle bold = rtb.SelectionFont.Style;
                bold ^= FontStyle.Bold;
                rtb.SelectionFont = new Font(rtb.SelectionFont.FontFamily, rtb.SelectionFont.Size, bold);
            }
        }
        private void tsItalic_Click(object sender, EventArgs e)
        {
            tsItalic.Checked = !tsItalic.Checked;
            int a = rtb.SelectionStart;
            int b = rtb.SelectionLength + a;

            if (b - a != 0)
            {
                for (int i = a; i < b; i++)
                {
                    rtb.SelectionStart = i;
                    rtb.SelectionLength = 1;
                    rtb.SelectionFont = new Font(rtb.SelectionFont.FontFamily, rtb.SelectionFont.Size, rtb.SelectionFont.Style ^ FontStyle.Italic);
                }
                rtb.SelectionStart = a;
                rtb.SelectionLength = b - a;
            }
            else
            {
                FontStyle italic = rtb.SelectionFont.Style;
                italic ^= FontStyle.Italic;
                rtb.SelectionFont = new Font(rtb.SelectionFont.FontFamily, rtb.SelectionFont.Size, italic);
            }
        }
        private void tsUnderline_Click(object sender, EventArgs e)
        {
            tsUnderline.Checked = !tsUnderline.Checked;
            int a = rtb.SelectionStart;
            int b = rtb.SelectionLength + a;

            if (b - a != 0)
            {
                for (int i = a; i < b; i++)
                {
                    rtb.SelectionStart = i;
                    rtb.SelectionLength = 1;
                    rtb.SelectionFont = new Font(rtb.SelectionFont.FontFamily, rtb.SelectionFont.Size, rtb.SelectionFont.Style ^ FontStyle.Underline);
                }
                rtb.SelectionStart = a;
                rtb.SelectionLength = b - a;
            }
            else
            {
                FontStyle under = rtb.SelectionFont.Style;
                under ^= FontStyle.Underline;
                rtb.SelectionFont = new Font(rtb.SelectionFont.FontFamily, rtb.SelectionFont.Size, under);
            }
        }
        private void tsFontSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tsFontSize.Focused == false)
            {
                return;
            }
            ubahSize();
        }
        private void tsFont_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tsFont.Focused == false)
            {
                return;
            }
            ubahFont();
        }
        private void tsColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tsColor.Focused == false)
            {
                return;
            }
            ubahWarna();
        }
        private void ubahSize()
        {
            try
            {
                float size = (tsFontSize.Text == "") ? 12 : Convert.ToInt16(tsFontSize.Text);
                int a = rtb.SelectionStart;
                int b = rtb.SelectionLength + a;
                if (b - a != 0)
                {
                    for (int i = a; i < b; i++)
                    {
                        rtb.SelectionStart = i;
                        rtb.SelectionLength = 1;
                        rtb.SelectionFont = new Font(rtb.SelectionFont.FontFamily, size, rtb.SelectionFont.Style);
                    }
                    rtb.SelectionStart = a;
                    rtb.SelectionLength = b - a;
                }
                else
                {
                    rtb.SelectionFont = new Font(rtb.SelectionFont.FontFamily, size, rtb.SelectionFont.Style);
                }
            }
            catch
            {
                return;
            }
        }
        private void ubahFont()
        {
            int a = rtb.SelectionStart;
            int b = rtb.SelectionLength + a;
            try
            {
                if (b - a != 0)
                {
                    string fnt = tsFont.Text;
                    for (int i = a; i < b; i++)
                    {
                        rtb.SelectionStart = i;
                        rtb.SelectionLength = 1;
                        rtb.SelectionFont = new Font(fnt, rtb.SelectionFont.Size, rtb.SelectionFont.Style);
                    }
                    rtb.SelectionStart = a;
                    rtb.SelectionLength = b - a;
                }
                else
                {
                    rtb.SelectionFont = new Font(tsFont.Text, rtb.SelectionFont.Size, rtb.SelectionFont.Style);

                }
            }
            catch
            {
                return;
            }
        }
        private void ubahWarna()
        {
            try
            {
                rtb.SelectionColor = Color.FromName(tsColor.Text);
            }
            catch
            {
                return;
            }
        }
        private void rtb_SelectionChanged(object sender, EventArgs e)
        {
            tsBold.Checked = tsItalic.Checked = tsUnderline.Checked = false;

            if (rtb.SelectionFont == null)
            {
                tsFontSize.Text = "";
                tsFont.Text = "";
            }
            else
            {
                tsFont.Text = rtb.SelectionFont.Name;
                tsFontSize.Text = rtb.SelectionFont.Size.ToString();
                if (rtb.SelectionFont.Bold)
                {
                    tsBold.Checked = true;
                }
                if (rtb.SelectionFont.Italic)
                {
                    tsItalic.Checked = true;
                }
                if (rtb.SelectionFont.Underline)
                {
                    tsUnderline.Checked = true;
                }
            }

            if (rtb.SelectionColor.Name == "0")
            {
                tsColor.Text = "";
            }
            else
            {
                tsColor.Text = rtb.SelectionColor.Name;
            }
        }
        private void Form1_Resize(object sender, EventArgs e)
        {
            rtb.Height = this.Height;
            rtb.Width = this.Width;
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

    }
}
