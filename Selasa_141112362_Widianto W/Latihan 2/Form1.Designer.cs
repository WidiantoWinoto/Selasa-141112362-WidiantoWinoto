namespace Latihan_2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.domainUpDown1 = new System.Windows.Forms.DomainUpDown();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.domainUpDown2 = new System.Windows.Forms.DomainUpDown();
            this.SuspendLayout();
            // 
            // domainUpDown1
            // 
            this.domainUpDown1.Items.Add("Januari");
            this.domainUpDown1.Items.Add("Februari");
            this.domainUpDown1.Items.Add("Maret");
            this.domainUpDown1.Items.Add("April");
            this.domainUpDown1.Items.Add("Mei");
            this.domainUpDown1.Items.Add("Juni");
            this.domainUpDown1.Items.Add("Juli");
            this.domainUpDown1.Items.Add("Agustus");
            this.domainUpDown1.Items.Add("September");
            this.domainUpDown1.Items.Add("Oktober");
            this.domainUpDown1.Items.Add("November");
            this.domainUpDown1.Items.Add("Desember");
            this.domainUpDown1.Location = new System.Drawing.Point(101, 23);
            this.domainUpDown1.Name = "domainUpDown1";
            this.domainUpDown1.Size = new System.Drawing.Size(120, 20);
            this.domainUpDown1.TabIndex = 0;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.CalendarDimensions = new System.Drawing.Size(2, 2);
            this.monthCalendar1.Location = new System.Drawing.Point(12, 55);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(251, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 38);
            this.button1.TabIndex = 3;
            this.button1.Text = "Tambah";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(343, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 38);
            this.button2.TabIndex = 4;
            this.button2.Text = "Hapus";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // domainUpDown2
            // 
            this.domainUpDown2.Items.Add("1");
            this.domainUpDown2.Items.Add("2");
            this.domainUpDown2.Items.Add("3");
            this.domainUpDown2.Items.Add("4");
            this.domainUpDown2.Items.Add("5");
            this.domainUpDown2.Items.Add("6");
            this.domainUpDown2.Items.Add("7");
            this.domainUpDown2.Items.Add("8");
            this.domainUpDown2.Items.Add("9");
            this.domainUpDown2.Items.Add("10");
            this.domainUpDown2.Items.Add("11");
            this.domainUpDown2.Items.Add("12");
            this.domainUpDown2.Items.Add("13");
            this.domainUpDown2.Items.Add("14");
            this.domainUpDown2.Items.Add("15");
            this.domainUpDown2.Items.Add("16");
            this.domainUpDown2.Items.Add("17");
            this.domainUpDown2.Items.Add("18");
            this.domainUpDown2.Items.Add("19");
            this.domainUpDown2.Items.Add("20");
            this.domainUpDown2.Items.Add("21");
            this.domainUpDown2.Items.Add("22");
            this.domainUpDown2.Items.Add("23");
            this.domainUpDown2.Items.Add("24");
            this.domainUpDown2.Items.Add("25");
            this.domainUpDown2.Items.Add("26");
            this.domainUpDown2.Items.Add("27");
            this.domainUpDown2.Items.Add("28");
            this.domainUpDown2.Items.Add("29");
            this.domainUpDown2.Items.Add("30");
            this.domainUpDown2.Items.Add("31");
            this.domainUpDown2.Location = new System.Drawing.Point(2, 23);
            this.domainUpDown2.Name = "domainUpDown2";
            this.domainUpDown2.Size = new System.Drawing.Size(93, 20);
            this.domainUpDown2.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 368);
            this.Controls.Add(this.domainUpDown2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.domainUpDown1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DomainUpDown domainUpDown1;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DomainUpDown domainUpDown2;
    }
}

