﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button29_Click(object sender, EventArgs e)
        {
            Form2 secondWindow = new Form2();
            secondWindow.ShowDialog();

        }
    }
}
