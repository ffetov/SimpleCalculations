﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sumator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var num1 = double.Parse(textBox1.Text);
                var num2 = double.Parse(textBox2.Text);
                var sum = num1 + num2;
                textBox3.Text = sum.ToString();
                textBox3.Enabled = true;
            }
            catch (Exception)
            {
                textBox3.Text="error";
                textBox3.Enabled = true;
            }

        }
    }
}
