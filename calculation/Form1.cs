﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculation
{
    

    public partial class Form1 : Form
    {
        public decimal PriceHt;
        
        public Form1()
        {
            InitializeComponent();
        }

        
        private void Form1_Load(object sender, EventArgs e)
        {
            this.ActiveControl = textBox1;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            PriceHt = decimal.Parse(textBox1.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal Price;
            //PriceHt = decimal.Parse((textBox1.Text));
            Price = (decimal)86 / 1000;//* PriceHt + PriceHt;
            label1.Text = Price.ToString("C");
        }
    }
}
