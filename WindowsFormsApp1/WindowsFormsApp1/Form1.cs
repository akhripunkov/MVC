﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Controllers;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void askButton_Click(object sender, EventArgs e)
        {

            GetInfoController controller = new GetInfoController();

            MessageBox.Show(controller.Questinon(textBox1.Text));
        }
    }
}
