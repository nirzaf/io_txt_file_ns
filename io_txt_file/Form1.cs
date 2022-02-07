using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace io_txt_file
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string t;
            t = this.textBox1.Text;
            System.IO.File.WriteAllText("E:\\tuts\\info.txt", t,Encoding.UTF8);
            MessageBox.Show("Done!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string r;
          r=  System.IO.File.ReadAllText("E:\\tuts\\info.txt", Encoding.UTF8);
            this.textBox1.Text = r;
        }
    }
}
